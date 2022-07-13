<template>
    <div>
        <el-card class="box-card">
            <h3>Добавить цель</h3>
            <div style="display: flex;">
                <el-input placeholder="Цель" v-model="goal.text"></el-input>
                <el-button @click="addGoal">Добавить цель</el-button>
            </div>

            <el-divider></el-divider>
        </el-card>
    </div>
</template>

<script>
    export default {
        name: 'addgoal',
        event: 'change',
        data() {
            return {
                goal: {
                    text: ''
                }
            }
        },
        computed: {

        },
        methods: {
            addGoal: function () {
                var self = this;
                this.$axios.post('/goals', this.goal).then(function (response) {
                    console.log(response);
                    self.$emit('listen');
                    self.goal.text = '';
                }).catch(function (error) {
                    console.log(error);
                });
            }
        },
        created() {

        },
        mounted() {

        }
    }
</script>

<style>

</style>