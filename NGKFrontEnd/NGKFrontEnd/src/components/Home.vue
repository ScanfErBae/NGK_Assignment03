<template>
    <div class="home">
        <input type="text" v-model="name" placeholder="Name">
        <input type="text" v-model="email" placeholder="Email">
        <input type="password" v-model="password" placeholder="Password">
        <br />
        <button class="get" @click="register">Register</button>
        <br />
        <br />
        <br />
        <input type="text" v-model="name1" placeholder="Name">
        <input type="text" v-model="email1" placeholder="Email">
        <input type="password" v-model="password1" placeholder="Password">
        <br />
        <button class="get" @click="login">Login</button>
        <br />
        <br />
        <br />
        <input type="text" v-model="name2" placeholder="Name">
        <input type="text" v-model="lat" placeholder="Lat">
        <input type="text" v-model="long" placeholder="Long">
        <br />
        <button class="get" @click="postLocation">Post Location</button>
        <br />
    </div>
</template>

<script>
    export default {
        name: 'Home',
        data: function () {
            return {
                info: null,
                name: null,
                email: null,
                password: null,
                name1: null,
                name2: null,
                lat: null,
                long: null,
                email1: null,
                password1: null
            }
        },
        methods: {
            HandleErrors: function (response) {
                if (!response.ok) {
                    throw Error(response.statusText);
                }
                return response;
            },
            register() {
                fetch('https://localhost:44384/api/Account/Register', {
                    method: 'POST',
                    body: JSON.stringify({
                        Email: this.email,
                        Name: this.name,
                        Password: this.password
                    }),
                    headers: new Headers({
                        'Content-Type': 'application/json'
                    })
                }).then(this.HandleErrors)
                    .then(response => console.log(response))
                    .catch(error => console.log(error));
            },
            login() {
                fetch('https://localhost:44384/api/Account/Login', {
                    method: 'POST',
                    body: JSON.stringify({
                        Email: this.email1,
                        Name: this.name1,
                        Password: this.password1
                    }),
                    headers: new Headers({
                        'Content-Type': 'application/json'
                    })
                }).then(res => res.json().then((token) => {
                    localStorage.setItem("token", token);
                    console.log(res);

                }).catch(error => console.error('Error:', error)))
            },
        }
    };
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
    input {
        margin: 10px;
    }

    button {
        margin-left: 10px;
    }
</style>

