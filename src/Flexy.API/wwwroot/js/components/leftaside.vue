<template>
    <div class="left-aside">
        <el-menu class="el-menu-vertical-demo">
            <router-link :to="menuItem.url" tag="div" v-for="menuItem in menuItems">
                <el-menu-item>
                    <i :class="menuItem.icon"></i>
                    <span style="font-size:20px; padding-left:10px">{{menuItem.name}}</span>
                </el-menu-item>
            </router-link>
        </el-menu>
    </div>
</template>

<script>
    export default {
        name: 'leftaside',
        data() {
            return {
                menuItems: [
                    { name: 'Профиль', icon: 'el-icon-user', url: '/profile' },
                    { name: 'Цели и мечты', icon: 'el-icon-finished', url: '/goals' },
                    { name: 'Дневник Чемпиона', icon: 'el-icon-notebook-2', url: '/diary' },
                    { name: 'Советы и мотивации', icon: 'el-icon-coffee-cup', url: '/motivation' },
                    { name: 'Встречи', icon: 'el-icon-connection', url: '/meetings' },
                    //{ name: 'Персонажи', icon: 'el-icon-user', url: '/teachers' },
                    //{ name: 'Достижения', icon: 'el-icon-medal-1', url: '/achievments' },

                ],
            }
        },
        computed: {

        },
        methods: {
    
        },
        created() {

        },
        mounted() {
            
        }
    }
</script>

<style>
/*    @font-face {
        font-family: 'Cabin-Regular';
        src: url('~\fonts\Cabin-Regular.ttf') format('truetype');
    }*/
    .left-aside {
        position: fixed;
        top: 0;
        bottom: 0;
        width: 100%;
        max-width: 256px;
        margin-top: 100px;
        display: flex;
        flex-direction: column;
        overflow-y: auto;
        z-index: 1000;
    }

    .menu-item {
        font-size: 24px;
        padding-top: 18px;
    }

    .el-menu {
        background-color: #181C1F !important;
    }
    .el-menu-item {
        color: #E2B988 !important;
        /*        font-family: Cabin-Regular !important;*/
    }
</style>