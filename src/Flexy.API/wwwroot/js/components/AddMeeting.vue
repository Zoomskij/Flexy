<template>
    <div>
        <el-card class="box-card">
            <div style="display: flex; justify-content:space-between; vertical-align:central">
                <el-form ref="form" :model="form" label-width="120px">
                    <el-form-item label="Название встречи">
                        <el-input v-model="meeting.name"></el-input>
                    </el-form-item>
                    <el-form-item label="Описание">
                        <el-input v-model="meeting.description"></el-input>
                    </el-form-item>
                    <el-form-item label="Адрес">
                        <el-input v-model="meeting.address"></el-input>
                    </el-form-item>
                    <el-form-item label="Категория">
                        <el-input v-model="meeting.category"></el-input>
                    </el-form-item>
                    <el-form-item label="Превью Url">
                        <el-input v-model="meeting.img"></el-input>
                    </el-form-item>

                    <el-form-item>
                        <el-button type="primary" @click="addMeeting">Создать встречу</el-button>
                    </el-form-item>
                </el-form>
            </div>
        </el-card>
    </div>
</template>

<script>

    export default {
        name: 'addmeeting',
        data() {
            return {
                meeting: {
                    name: '',
                    description: '',
                    address: '',
                    isMetro: false,
                    metro: '',
                    category: '',
                    status: '',
                    img: ''
                }
            }
        },
        computed: {

        },
        methods: {
            addMeeting: function () {
                var self = this;
                this.$axios.post('/meetings', this.meeting).then(function (response) {
                    console.log(response);
                    document.location.href = '/meetings';
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