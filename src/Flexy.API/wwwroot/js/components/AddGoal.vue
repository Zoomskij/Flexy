<template>
    <div>

        <div style="display:flex; justify-content:space-between; padding-bottom:32px">
            <span>
                <span class="f1">ДОБАВИТЬ&nbsp;</span>
                <span class="f2">ЦЕЛЬ</span>
            </span>
        </div>

        <div style="display: flex;">
            <el-input placeholder="Цель" v-model="goal.text"></el-input>
            <el-button @click="addGoal" style="padding-left:10px">Добавить цель</el-button>
        </div>

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