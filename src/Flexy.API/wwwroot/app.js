import Vue from 'vue'
import VueRouter from 'vue-router'
import ElementUI from 'element-ui'
import locale from 'element-ui/lib/locale'
import ruLocale from 'element-ui/lib/locale/lang/ru-RU'

import axios from 'axios';

Vue.prototype.$axios = axios;

import Index from "~/js/components/index.vue";
import Scenario from "~/js/components/scenario.vue";
import Courses from "~/js/components/courses.vue";
import Achievments from "~/js/components/achievments.vue";
import Teachers from "~/js/components/teachers.vue";
import Goals from "~/js/components/goals.vue";
import RHeader from "~/js/components/rheader.vue";
import LeftAside from "~/js/components/leftaside.vue";


Vue.use(VueRouter);
locale.use(ruLocale);
Vue.use(ElementUI, { ruLocale });

Vue.component("scenario", Scenario);
Vue.component("rheader", RHeader);
Vue.component("left-aside", LeftAside);
Vue.component("achievments", Achievments);
Vue.component("teachers", Teachers);
Vue.component("index", Index);

function startOnLoad() {
    var router = new VueRouter({
        routes: [
            /* { path: '/', caseSensitive: false, component: Scenario },*/
            { path: '/', caseSensitive: false, component: Index },
            { path: '/teachers', caseSensitive: false, component: Teachers },
            { path: '/courses', caseSensitive: false, component: Courses },
            { path: '/scenario', caseSensitive: false, component: Scenario },
            { path: '/achievments', caseSensitive: false, component: Achievments },
            { path: '/goals', caseSensitive: false, component: Goals },
        ]
    });
    Vue.config.devtools = true;

    var vv = new Vue({
        el: "#vue-router",
        router,
        data: {

        },
        methods: {
            back() {
                this.$router.go(-1);
            },

            isCurrentRoute(name) {
                return this.$route.name === name;
            },
        },
    });


    var app = new Vue({
        el: '#app',
        router,
        data: {
            achievments: [],

        },
        mounted() {

        },
        computed: {

        },
        methods: {

        },
    })
}
startOnLoad();