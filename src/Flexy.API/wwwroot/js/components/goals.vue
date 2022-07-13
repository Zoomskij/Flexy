<template>
    <div>
        <el-card class="box-card achievments">
            <h3>Мои цели</h3>
            <span v-for="goal in goals">
                <el-alert :title="goal.text"
                          type="info">
                </el-alert>
                <el-divider></el-divider>
            </span>
            <add-goal @listen="getGoals"></add-goal>
        </el-card>
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