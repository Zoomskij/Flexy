<template>
    <div style="max-width:380px; padding-right:22px">

            <div style="display: flex; justify-content:space-between; vertical-align:central; align-items: center">
                <div>
                    <div>
                        <img :src="meeting.img" width="380" height="220" />
                    </div>
                    <div class="meeting-second-block">
                        <span class="meeting-name">{{meeting.name}}</span>
                    </div>


                    <!--<br />
                    <el-tag>{{meeting.category}}</el-tag>-->
                </div>
            </div>


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
    .meeting-name {
        font-family: Cabin;
        font-size: 17px;
        font-weight: 600;
        line-height: 21px;
        letter-spacing: 0em;
        text-align: left;
    }

    .meeting-second-block {
        background: rgba(217, 217, 217, 0.13);
        border-radius: 0px 0px 10px 10px;
        min-height: 80px;
        display: flex;
        align-items: center;
        padding: 10px;
        margin-top: -10px;
    }
</style>