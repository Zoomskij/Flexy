<template>
    <div>
        <div style="display:flex; justify-content:space-between; padding-bottom:32px">
            <span>
                <span class="f1">Вдохновлять может&nbsp;</span>
                <span class="f2">каждый!</span>
            </span>
        </div>
        <el-carousel :interval="4000" type="card" height="200px">
            <el-carousel-item v-for="item in 6" :key="item">
                <h3 class="medium">{{ item }}</h3>
            </el-carousel-item>
        </el-carousel>
    </div>
</template>

<script>
    import Mastermind from "~/js/components/Mastermind.vue";
    export default {
        name: 'masterminds',
        components: { Mastermind},
        data() {
            return {

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
    .el-carousel__item h3 {
        color: #475669;
        font-size: 14px;
        opacity: 0.75;
        line-height: 200px;
        margin: 0;
    }

    .el-carousel__item:nth-child(2n) {
        background-color: #99a9bf;
    }

    .el-carousel__item:nth-child(2n+1) {
        background-color: #d3dce6;
    }
</style>