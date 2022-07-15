<template>
    <div>
        <div style="display:flex; justify-content:space-between; padding-bottom:32px; padding-left:65px; padding-top:65px">
            <div>
                <div style="display:flex; align-items:start">
                    <span>
                        <span class="span2">МОИ ЦЕЛИ</span>
                    </span>
                </div>
                <div>
                    <el-button @click="addGoal" style="width: 130px; height: 30px; left: 310px; top: 247px; background: #3B138D; border-radius: 11px;">Поставить цель</el-button>
                </div>
            </div>
            <div class="slider">
                <div class="slider-select" style="width:33%">
                    <span>
                        <span class="span3">Все цели</span>
                    </span>
                </div>
                <div style="width:33%" class="slider-unselect">
                    <span>
                        <span class="span3">Глобальные цели</span>
                    </span>
                </div>
                <div style="width:33%" class="slider-unselect">
                    <span>
                        <span class="span3">Оперативные цели</span>
                    </span>
                </div>
            </div>
            <div>

            </div>
        </div>
        <div style="display:flex; justify-content: space-between">
            <div v-for="goal in goals" class="goal-background" style="display:block">
                <div style="display:block">
                    <el-card class="box-card" style="height: 90%; width: 90%; margin: 25px;">
                        <div>
                            <span style="color:black">Оперативная цель до 31 декабря  2022</span>
                        </div>
                        <div>
                            <b><span style="color:black; font-size:18px">{{goal.text}}</span></b>
                        </div>
                        <div>
                            <span style="color:black">Прогресс 1 из 3 задач</span>
                        </div>
                    </el-card>
                </div>
            </div>
            <div>
                <img src="https://raw.githubusercontent.com/Zoomskij/ImagesForBot/main/goal.png" width="90%" height="90%" />

            </div>
            <!--<add-goal @listen="getGoals"></add-goal>-->
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
    .slider {
        display: flex;
        justify-content: space-between;
        align-items: flex-end;
        position: absolute;
        width: 811px;
        height: 0px;
        left: 539px;
        top: 220px;
    }

    .slider-select {
        border-bottom: 3px solid #FFE600;
    }
    .slider-unselect {
        border-bottom: 3px solid #7D47BF;
    }

    .goal-background {
        width: 554px;
        height: 150px;
        left: 310px;
        top: 310px;
        background: rgba(217, 217, 217, 0.12);
        border-radius: 12px;
    }

</style>