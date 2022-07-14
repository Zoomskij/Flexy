<template>
    <div>
        <div style="display:flex">
            <div>
                <img :src="comment.user.avatar" width="64" height="64" style="border-radius:50%" />
            </div>
            <div style="padding-left:10px">
                <div>
                    <span>{{comment.user.firstName}} {{comment.user.lastName}}</span>
                </div>
                <div>
                    <span>{{comment.text}}</span>
                </div>
                <div style="display:flex">
                    <span>{{convertDate}}</span>
                    <span style="padding-left:5px; padding-right:5px">|</span>
                    <el-link type="primary">комментировать</el-link>
                </div>
            </div>
        </div>
        <el-divider></el-divider>
    </div>
</template>

<script>
    import moment from 'moment';
    import 'moment/locale/ru'
    moment.locale('ru')
    export default {
        name: 'diary-comment',
        props: ['comment'],
        data() {
            return {

            }
        },
        computed: {
            convertDate: function () {
                let date = moment(this.comment.createdDate);
                return date.calendar();
            }
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