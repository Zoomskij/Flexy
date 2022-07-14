import Vue from 'vue'
import Vuex from 'vuex';
import VueRouter from 'vue-router'
import ElementUI from 'element-ui'
import locale from 'element-ui/lib/locale'
import ruLocale from 'element-ui/lib/locale/lang/ru-RU'
import 'element-theme-dark';

/*import { router } from '~/js/helpers/router.js';*/


import axios from 'axios';

axios.defaults.headers.common["Authorization"] = "Bearer " + localStorage.getItem("token");

Vue.prototype.$axios = axios;

import { alert } from '~/js/alert.module.js';
import { account } from '~/js/account.module.js';
import { users } from '~/js/users.module.js';

import Index from "~/js/components/index.vue";
import Scenario from "~/js/components/scenario.vue";
import Courses from "~/js/components/courses.vue";
import Achievments from "~/js/components/achievments.vue";
import Teachers from "~/js/components/teachers.vue";8
import Goals from "~/js/components/goals.vue";
import RHeader from "~/js/components/rheader.vue";
import LeftAside from "~/js/components/leftaside.vue";
import Meetings from "~/js/components/Meetings.vue";
import Diary from "~/js/components/Diary.vue";

import HomePage from '~/js/components/HomePage.vue'
import LoginPage from '~/js/components/LoginPage.vue'
import RegisterPage from '~/js/components/RegisterPage.vue'

import AddMeeting from '~/js/components/AddMeeting.vue'
import MasterMinds from '~/js/components/MasterMinds.vue';

Vue.use(VueRouter);
locale.use(ruLocale);
Vue.use(ElementUI, { ruLocale });
Vue.use(Vuex);

Vue.component("scenario", Scenario);
Vue.component("rheader", RHeader);
Vue.component("left-aside", LeftAside);
Vue.component("achievments", Achievments);
Vue.component("teachers", Teachers);
Vue.component("index", Index);

export const store = new Vuex.Store({   
    modules: {
        alert,
        account,
        users
    }
});

function startOnLoad() {
    var router = new VueRouter({
        routes: [
            { path: '/', component: HomePage },
            { path: '/login', component: LoginPage },
            { path: '/register', component: RegisterPage },
            { path: '/addmeeting', component: AddMeeting },
            

            /* { path: '/', caseSensitive: false, component: Scenario },*/
            //{ path: '/', caseSensitive: false, component: Index },
            { path: '/teachers', caseSensitive: false, component: Teachers },
            { path: '/courses', caseSensitive: false, component: Courses },
            { path: '/scenario', caseSensitive: false, component: Scenario },
            { path: '/achievments', caseSensitive: false, component: Achievments },
            { path: '/goals', caseSensitive: false, component: Goals },
            { path: '/meetings', caseSensitive: false, component: Meetings },
            { path: '/diary', caseSensitive: false, component: Diary },
            { path: '/masterminds', caseSensitive: false, component: MasterMinds },
            

            // otherwise redirect to home
            { path: '*', redirect: '/' }

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
        store,
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