<template>
    <div>
        <div>
            <div style="display:flex; justify-content:space-between; padding-bottom:32px">
                <span>
                    <span class="f1">ДНЕВНИК&nbsp;</span>
                    <span class="f2">ЧЕМПИОНА</span>
                </span>
            </div>
            <el-divider></el-divider>

            <div style="display: flex;">
                <el-input v-model="comment.text"></el-input>
                <el-button @click="addGoal">Добавить цель</el-button>
            </div>

            <!--<div style="display: flex;">
                <meeting :meeting="meeting" v-for="meeting in meetings"></meeting>
            </div>-->
        </div>
    </div>
</template>

<script>
/*    import AddGoal from "~/js/components/AddGoal.vue";*/
    export default {
        name: 'diary',
/*        components: { 'add-goal': AddGoal },*/
        data() {
            return {
                comment: {
                    text: ''
                },
                diaryComments: []
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

</style>