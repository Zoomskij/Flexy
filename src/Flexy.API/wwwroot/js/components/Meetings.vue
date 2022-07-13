<template>
    <div>
        <div>
            <div style="display:flex; justify-content:space-between; padding-bottom:32px">
                <span>
                    <span class="f1">БЛИЖАЙШИЕ&nbsp;</span>
                    <span class="f2">ВСТРЕЧИ</span>
                </span>

                <router-link to="/addmeeting">
                    <el-button type="primary">Создать новую встречу</el-button>
                </router-link>
            </div>

            <div style="display: flex;">
                <meeting :meeting="meeting" v-for="meeting in meetings"></meeting>
            </div>
        </div>

        <div style="padding-top:52px;">
            <div style="display:flex; justify-content:space-between; padding-bottom:32px">
                <span>
                    <span class="f1">ТО, ЧТО МОЖЕТ БЫТЬ ТЕБЕ</span><br />
                    <span class="f2">ИНТЕРЕСНЫМ</span>
                </span>
            </div>

            <div style="display: flex;">
                <meeting :meeting="meeting" v-for="meeting in meetings"></meeting>
            </div>
        </div>

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