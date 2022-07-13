<template>
    <div>
        <el-card class="box-card">
            <div style="display: flex; justify-content:space-between; vertical-align:central">
                <div>
                    <img :src="meeting.img" widht="150" height="100" />
                    <span>{{meeting.name}}</span>
                    <span>{{meeting.description}}</span>
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