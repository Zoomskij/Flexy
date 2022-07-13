<template>
    <div style="max-width:340px; padding-right:10px">
        <el-card class="box-card">
            <div style="display: flex; justify-content:space-between; vertical-align:central; align-items: center">
                <div>
                    <h2>{{meeting.name}}</h2>
                    <img :src="meeting.img" width="300" height="200" />
                    <h4>{{meeting.description}}</h4>
                    <br />
                    <el-tag>{{meeting.category}}</el-tag>
                </div>
            </div>

        </el-card>
    </div>
</template>

<script>

    export default {
        name: 'meeting',
        props: ['meeting'],
        data() {
            return {

            }
        },
        computed: {

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