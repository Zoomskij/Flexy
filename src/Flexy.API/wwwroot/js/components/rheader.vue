<template>
    <div class="header">

        <div style="display: flex; justify-content: flex-start; align-items: center;">
            <div style="display:flex; justify-content: flex-start; align-items:center;padding-left:50px; cursor:pointer">
                <router-link to="/" tag="div">
                    <img src="https://raw.githubusercontent.com/Zoomskij/ImagesForBot/main/logo.png" width="178" height="28" />
                </router-link>
            </div>
            <div style="display:flex; padding-left:220px">
                <router-link to="/" tag="div">
                    <span class="menu-item-span">Главная</span>
                </router-link>
                <router-link to="/" tag="div">
                    <span class="menu-item-span">О Вдохновителях</span>
                </router-link>
            </div>
            <div style="position:fixed; right: 0; display: flex; justify-content: flex-end; align-items: center; padding: 4px; height: 64px">

                <span style="padding-right:10px" class="menu-item-span">{{user.username}}</span>
                <span class="menu-item-span" @click="logout" v-if="user.token">Выйти</span>
                <router-link to="/login" class="btn btn-link" v-else>
                    <span class="menu-item-span">Войти</span>
                </router-link>
                <span class="menu-item-span">Дневник мечты</span>
                
            </div>
        </div>


        <el-dialog title="Авторизация" :visible.sync="isAuthWindow">
            <el-input placeholder="username" v-model="authenticateRequest.username"></el-input>
            <el-input placeholder="password" v-model="authenticateRequest.password" show-password style="padding-top:10px"></el-input>

            <span slot="footer" class="dialog-footer">
                <el-button type="primary" @click="auth()">Войти</el-button>
            </span>
        </el-dialog>
    </div>
</template>

<script>
    export default {
        name: 'rheader',
        data() {
            return {
                user: [],
                isAuthWindow: false,
                authenticateRequest: {
                    username: '',
                    password: ''
                }

            }
        },
        computed: {

        },
        methods: {
            auth: function () {
                var self = this;
                this.$axios.post('users/authenticate', this.authenticateRequest).then(function (response) {
                    console.log(response.data);
                    if (response.data.token) {
                        localStorage.setItem('user', JSON.stringify(response.data));
                        self.user = response.data;
                        self.isAuthWindow = false;
                    }
                    return response.data;
                }).catch(function (error) {
                    console.log(error);
                });
            },
            logout: function() {
                localStorage.removeItem('user');
                localStorage.removeItem('token');
                this.user = [];
                document.location.href = '/';
            }
        },
        created() {
            let user = JSON.parse(localStorage.getItem('user'));

            if (user && user.token) {
                this.user = user;
                return {
                    'Authorization': 'Bearer ' + user.token
                };
            } else {
                return {};
            }
        },
        mounted() {
            
        }
    }
</script>

<style>
    .el-row {
        margin-bottom: 20px;
        &:last-child

    {
        margin-bottom: 0;
    }

    }

    .el-col {
        border-radius: 4px;
    }

    .bg-purple-dark {
        background: #99a9bf;
    }

    .bg-purple {
        background: #d3dce6;
    }

    .bg-purple-light {
        background: #e5e9f2;
    }

    .grid-content {
        border-radius: 4px;
        min-height: 36px;
    }

    .row-bg {
        padding: 10px 0;
        background-color: #f9fafc;
    }

    .header {
        position: fixed;
        width: 100%;
        height: 112px;
        z-index: 1000;
        border-bottom: solid 1px #F876A5 !important;
        display: flex;
        justify-content: flex-start;
        align-items: center;
    }


    .menu-item-span {
        font-size: 13px;
        padding-left: 10px;
        color: #FFFFFF;
        cursor: pointer;
    }

        .menu-item-span:hover, select {
            color: #FFE600;
        }
</style>