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
                <el-button @click="addDiaryComment">Добавить запись</el-button>
            </div>

            <div>
                <span v-for="diaryComment in diaryComments">
                    <span>{{diaryComment.text}}</span>
                    <el-divider></el-divider>
                </span>
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
            getDiaryComments: function () {
                var self = this;
                this.$axios.get('/diary')
                    .then(function (response) {
                        self.diaryComments = response.data;
                    });
            },

            addDiaryComment: function () {
                var self = this;
                this.$axios.post('/diary', this.comment).then(function (response) {
                    console.log(response);
                    self.comment.text = '';
                    self.getDiaryComments();
                }).catch(function (error) {
                    console.log(error);
                });
            }
        },
        created() {

        },
        mounted() {
            this.getDiaryComments();
        }
    }
</script>

<style>

</style>