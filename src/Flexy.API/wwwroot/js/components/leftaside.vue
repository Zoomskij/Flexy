<template>
    <div class="left-aside">
        <el-menu class="el-menu-vertical-demo">
            <router-link :to="menuItem.url" tag="div" v-for="menuItem in menuItems">
                <el-menu-item>
                    <span class="menu-item-span">{{menuItem.name}}</span>
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
                    { name: 'Дневник мечты', icon: 'el-icon-finished', url: '/goals' },
                    { name: 'Дневник Чемпиона', icon: 'el-icon-notebook-2', url: '/diary' },
                    { name: 'Советы и мотивации', icon: 'el-icon-coffee-cup', url: '/motivation' },
                    { name: 'Встречи', icon: 'el-icon-connection', url: '/meetings' },


                    //{ name: 'Вдохновители', icon: 'el-icon-view', url: '/masterminds' },
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
        max-width: 230px;
        margin-top: 113px;
        display: flex;
        flex-direction: column;
        overflow-y: auto;
        z-index: 1000;
    }

    .menu-item {
        font-family: Inter;
        font-size: 11px;
        font-weight: 600;
        line-height: 13px;
        letter-spacing: 0.04em;
        text-align: left;
        padding-top: 18px;
    }

    .el-menu {
        height: 100% !important;
        background-color: transparent !important;
        border-right: solid 1px #F876A5 !important;
    }
    .el-menu-item {
        color: #FFFFFF !important;
        font-family: Inter !important;
        padding-left: 50px !important;
    }

    .menu-item-span {
        font-size: 13px;
        padding-left: 10px;
    }
        .menu-item-span:hover, select {
            color: #FFE600;
        }

    .el-menu-item:focus, .el-menu-item:hover {
        outline: 0 !important;
        background-color: transparent !important;
    }
</style>