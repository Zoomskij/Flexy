<template>
    <div class="header">
        <el-row>
            <el-col :span="24">
                <div style="display: flex; justify-content: space-between;">
                    <div style="display:flex; justify-content: flex-start; align-items:center">
                        <router-link to="/" tag="div">
                            <h3>Flexy</h3>
                        </router-link>
                    </div>
                    <div style="display:flex; justify-content: flex-end; align-items:center; padding: 4px; height:40px">
                        <div>
                            <img src="https://x.boardgamearena.net/data/avatar/0/89/89706/89706650_184.jpg?h=020a78627c" width="64" height="64" style="border-radius:50%" />
                        </div>
                        <span style="padding-right:10px">{{user.username}}</span>
                        <el-button type="primary" @click="logout" v-if="user.token">Выйти</el-button>
                        <router-link to="/login" class="btn btn-link" v-else>
                            <el-button type="primary">Войти</el-button>
                        </router-link>
                    </div>
                </div>
            </el-col>
        </el-row>

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
        height: 100px;
        z-index:1000;
    }
</style>