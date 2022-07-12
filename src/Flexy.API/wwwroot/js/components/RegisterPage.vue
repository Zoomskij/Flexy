<template>
    <div>
        <h2>Register</h2>
        <form @submit.prevent="handleSubmit">
            <div class="form-group">
                <label for="firstName">First Name</label>
                <input type="text" v-model="user.firstName" name="firstName" class="form-control" />
            </div>
            <div class="form-group">
                <label for="lastName">Last Name</label>
                <input type="text" v-model="user.lastName"  name="lastName" class="form-control"  />
            </div>
            <div class="form-group">
                <label for="username">Username</label>
                <input type="text" v-model="user.username"  name="username" class="form-control"  />
            </div>
            <div class="form-group">
                <label htmlFor="password">Password</label>
                <input type="password" v-model="user.password" name="password" class="form-control" />
            </div>
            <div class="form-group">
                <button class="btn btn-primary" >Register</button>
                <router-link to="/login" class="btn btn-link">Cancel</router-link>
            </div>
        </form>
    </div>
</template>

<script>
    import { mapState, mapActions } from 'vuex'

    export default {
        data() {
            return {
                user: {
                    firstName: '',
                    lastName: '',
                    username: '',
                    password: ''
                },
                submitted: false
            }
        },
        computed: {
            ...mapState('account', ['status'])
        },
        methods: {
            ...mapActions('account', ['register']),
            handleSubmit(e) {
                //this.submitted = true;
                //console.log(this.user);
                //this.register(this.user);

                var self = this;
                this.$axios.post('users/register', this.user).then(function (response) {
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