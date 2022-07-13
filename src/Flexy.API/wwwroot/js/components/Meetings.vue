<template>
    <div>
        <div style="display:flex; justify-content:space-between; padding-bottom:10px">
            <span><b>Встречи</b></span>
            <router-link to="/addmeeting" class="btn btn-link">Создать новую встречу</router-link>
        </div>

        <div v-for="meeting in meetings">
            <meeting :meeting="meeting"></meeting>
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