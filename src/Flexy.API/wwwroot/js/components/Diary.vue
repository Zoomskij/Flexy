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
                <el-button @click="addDiaryComment" style="padding-left:10px">Добавить запись</el-button>
            </div>

            <div style="padding-top:10px">
                <diary-comment :comment="diaryComment" v-for="diaryComment in diaryComments"></diary-comment>
            </div>

        </div>
    </div>
</template>

<script>
    import DiaryComment from "~/js/components/DiaryComment.vue";
    export default {
        name: 'diary',
        components: { 'diary-comment': DiaryComment },
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