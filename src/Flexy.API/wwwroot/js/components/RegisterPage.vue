<template>
    <div style="width:300px">
        <h2>Регистрация</h2>
        <form @submit.prevent="handleSubmit">
            <div class="form-group">
                <label for="firstName">Имя</label>
                <el-input v-model="user.firstName" name="username" width="300"></el-input>
            </div>
            <div class="form-group">
                <label for="lastName">Фамилия</label>
                <el-input v-model="user.lastName" name="username" width="300"></el-input>
            </div>
            <div class="form-group">
                <label for="username">Логин</label>
                <el-input v-model="user.username" name="username" width="300"></el-input>
            </div>
            <div class="form-group">
                <label htmlFor="password">Пароль</label>
                <el-input v-model="user.password" name="password" width="300" type="password"></el-input>
            </div>
            <div class="form-group">
                <button class="btn btn-primary">Регистрация</button>
                <router-link to="/login">
                    <el-link type="primary">Отмена</el-link>
                </router-link>
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
        padding-top: 10px;
    }
</style>
