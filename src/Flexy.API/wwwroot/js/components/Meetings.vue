<template>
    <div>
        <div style="display:flex; justify-content:space-between; padding-bottom:10px">
            <span><b>Встречи</b></span>
            <router-link to="/addmeeting" class="btn btn-link">Создать новую встречу</router-link>
        </div>

        <div v-for="meeting in meetings">
            <span>{{meeting.Name}}!</span>
        </div>
        <!--<div v-for="course in courses" style="padding-left:10px; display: flex;">
            <course :course="course" @listen="getCourses()"></course>
        </div>-->

        <!--<el-dialog title="Добавить курс" :visible.sync="isNewWindow">
            <el-input placeholder="Название курса" v-model="courseEntity.name"></el-input>
            <el-input placeholder="Описание курса" v-model="courseEntity.description" style="padding-top:10px"></el-input>
            <el-input placeholder="Url картинки" v-model="courseEntity.img" style="padding-top:10px"></el-input>

            <span slot="footer" class="dialog-footer">
                <el-button type="primary" @click="addCourse()">Добавить курс</el-button>
            </span>
        </el-dialog>-->
    </div>
</template>

<script>
    import Meeting from "~/js/components/Meeting.vue";
    
    export default {
        name: 'meetings',
        components: { Meeting },
        data() {
            return {
                meetings: [],
            }
        },
        computed: {

        },
        methods: {
            getMeetings: function () {
                var self = this;
                this.$axios.get('/meetings')
                    .then(function (response) {
                        self.meetings = response.data;
                    });
            },
        },
        created() {

        },
        mounted() {
            this.getMeetings();
        }
    }
</script>

<style>
    .clearfix:before,
    .clearfix:after {
        display: table;
        content: "";
    }

    .clearfix:after {
        clear: both
    }
</style>