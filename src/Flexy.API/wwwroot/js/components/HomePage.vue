<template>
    <div>
        <div style="display:flex; justify-content:space-between; padding-bottom:32px">
            <span>
                <span class="f1">Привет,&nbsp;</span>
                <span class="f2">{{account.user.firstName}}!</span>
            </span>
        </div>

    </div>
</template>

<script>
    import { mapState, mapActions } from 'vuex'

    export default {
        computed: {
            ...mapState({
                account: state => state.account,
                users: state => state.users.all
            })
        },
        created() {
           // this.getAllUsers();
        },
        methods: {
            //...mapActions('users', {
            //    getAllUsers: 'getAll',
            //    deleteUser: 'delete'
            //})
        }
    };
</script>