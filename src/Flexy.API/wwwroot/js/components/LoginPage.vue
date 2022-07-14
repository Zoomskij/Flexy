<template>
    <div style="width:300px">
        <h2>Авторизация</h2>
        <form @submit.prevent="handleSubmit">
            <div class="form-group">
                <label for="user.username">Логин</label>
                <el-input v-model="user.username" name="username" width="300"></el-input>
                <div v-show="submitted && !user.username" class="invalid-feedback">Username is required</div>
            </div>
            <div class="form-group">
                <label htmlFor="user.password">Пароль</label>
                <el-input v-model="user.password" name="password" width="300" type="password"></el-input>
                <div v-show="submitted && !user.password" class="invalid-feedback">Password is required</div>
            </div>
            <div class="form-group">
                <button class="btn btn-primary">Войти</button>
                <router-link to="/register">
                    <el-link type="primary">Регистрация</el-link>
                </router-link>
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
        //this.logout();
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
                    localStorage.setItem('token', response.data.token);
                    self.user = response.data;
                    document.location.href = '/';
                }
                return response.data;
            }).catch(function (error) {
                console.log(error);
            });
        }
    }
};
</script>

<style>
    .form-group {
        padding-top:10px;
    }
</style>