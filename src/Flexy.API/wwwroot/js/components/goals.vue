<template>
    <div>
        <div style="display:flex; justify-content:space-between; padding-bottom:32px">
            <span>
                <span class="f1">МОИ,&nbsp;</span>
                <span class="f2">ЦЕЛИ</span>
            </span>
        </div>
        <div>
            <span v-for="goal in goals">
                <el-alert :title="goal.text"
                          type="info">
                </el-alert>
                <el-divider></el-divider>
            </span>
            <add-goal @listen="getGoals"></add-goal>
        </div>

    </div>
</template>

<script>
    import AddGoal from "~/js/components/AddGoal.vue";
    export default {
        name: 'goals',
        components: { 'add-goal': AddGoal },
        data() {
            return {
                goals: []
            }
        },
        computed: {

        },
        methods: {
            getGoals: function () {
                var self = this;
                this.$axios.get('/goals')
                    .then(function (response) {
                        self.goals = response.data;
                    })
                    .catch(function (error) {
                        console.log(error);
                    });
            },
        },
        created() {

        },
        mounted() {
            this.getGoals();
        }
    }
</script>

<style>

</style>