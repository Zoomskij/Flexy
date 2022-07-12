<template>
    <div>
        <h2>Login</h2>
        <form @submit.prevent="handleSubmit">
            <div class="form-group">
                <label for="user.username">Username</label>
                <input type="text" v-model="user.username" name="username" class="form-control" />
                <div v-show="submitted && !user.username" class="invalid-feedback">Username is required</div>
            </div>
            <div class="form-group">
                <label htmlFor="user.password">Password</label>
                <input type="password" v-model="user.password" name="password" class="form-control" />
                <div v-show="submitted && !user.password" class="invalid-feedback">Password is required</div>
            </div>
            <div class="form-group">
                <button class="btn btn-primary" >Login</button>
                <router-link to="/register" class="btn btn-link">Register</router-link>
            </div>
        </form>
    </div>
</template>

<script>
import { mapState, mapActions } from 'vuex'

export default {
    data () {
        return {
            user: {
                username: '',
                password: ''
            },
            submitted: false
        }
    },
    computed: {
        ...mapState('account', ['status'])
    },
    created () {
        // reset login status
        this.logout();
    },
    methods: {
        ...mapActions('account', ['login', 'logout']),
        handleSubmit (e) {
            //this.submitted = true;
            //const { username, password } = this;
            //if (username && password) {
            //    this.login({ username, password })
            //}

            var self = this;
            this.$axios.post('users/authenticate', this.user).then(function (response) {
                console.log(response.data);
                if (response.data.token) {
                    localStorage.setItem('user', JSON.stringify(response.data));
                    self.user = response.data;
                }
                return response.data;
            }).catch(function (error) {
                console.log(error);
            });
        }
    }
};
</script>