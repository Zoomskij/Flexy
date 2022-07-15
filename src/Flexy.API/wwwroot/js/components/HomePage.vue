<template>
    <div style="padding-top: 65px; padding-left: 65px">
        <div style="display:flex;">
            <div>
                <div>
                    <span class="span1">
                        Открой свою суперсилу!
                    </span>
                </div>
                <div style="padding-top:14px">
                    <span class="span2">
                        Мечтай, выбирай и достигай всего сам.<br />Государственная программа поддержки талантов<br />Вдохновители помогут тебе в этом
                    </span>
                </div>

                <div style="padding-top:14px">
                    <span class="span3">
                        Подать заявку
                    </span>
                </div>
            </div>
            <div>
                <img src="https://raw.githubusercontent.com/Zoomskij/ImagesForBot/main/rocket.png" width="90%" height="90%" />
            </div>
        </div>

        <div style="display:flex; align-items:center">
            <div style="width:33%">
                <div style="display: flex; justify-content: flex-start; align-items: center;">
                    <img src="https://raw.githubusercontent.com/Zoomskij/ImagesForBot/main/104.png" />
                    <span class="span2">— Удобно</span>
                </div>
                <div style="padding-top:12px">
                    <span class="span3">
                        <b>В “Дневнике Мечты” каждый может узнать о возможностях программы поддержки подростков для:</b><br /><br />• раскрытия своего таланта<br />• получения знаний и развития компетенций<br />• поддержки и реализации проектов<br />• трудоустройства
                    </span>
                </div>

            </div>
            <div style="width:33%">
                <div style="display: flex; justify-content: flex-start; align-items: center;">
                    <img src="https://raw.githubusercontent.com/Zoomskij/ImagesForBot/main/105.png" />
                    <span class="span2">— Доступно</span>
                </div>
                <div style="padding-top:12px">
                    <span class="span3">
                        <b>Каждый молодой человек может выбрать меры поддержки, вдохновения необходимые именно ему:</b><br /><br /> построение индивидуального плана, консультации Вдохновителей, встречи с экспертами, профессиональные пробы и стажировки, поддержка проектов и т.д.
                    </span>
                </div>

            </div>
            <div style="width:33%">
                <div style="display: flex; justify-content: flex-start; align-items: center; ">
                    <img src="https://raw.githubusercontent.com/Zoomskij/ImagesForBot/main/106.png" />
                    <span class="span2">— Эффективно</span>
                </div>
                <div style="padding-top:12px">
                    <span class="span3">
                        <b>Каждый может найти здесь свою роль: молодой человек, вдохновитель, эксперт, родитель, учитель, вожатый.</b><br /><br /> Достаточно иметь телефон и интернет, чтобы создать личный кабинет на портале и прямо сейчас узнать о возможностях для дичного и профессионального развития.
                    </span>
                </div>

            </div>
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

<style>

</style>