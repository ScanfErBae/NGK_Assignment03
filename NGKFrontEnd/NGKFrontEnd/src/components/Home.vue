<template>
    <div class="home">

        <br />
        <button class="get" @click="showLocations">Show all Locations</button>
        <br />
        <span v-html="infoLocation">{{infoLocation}}</span>
        <br />
        <br />
        <button class="get" @click="showMeasurements">Show all Mesurements</button>
        <br />
        <span v-html="infoMeasurements">{{infoMeasurements}}</span>
        <br />
        <br />
        <br />
        <button class="get" @click="showSpeceficLocations">Show specefic Locations</button>
        <br />
        <input type="text" v-model="locationId" placeholder="Enter id for location" />
        <br />
        <span v-html="infoSpeceficLocation">{{infoSpeceficLocation}}</span>
        <br />
        <br />
        <button class="get" @click="showSpeceficMeasurements">Show specefic Measurements</button>
        <br />
        <input type="text" v-model="measurementId" placeholder="Enter id for measurement" />
        <br />
        <span v-html="infoSpeceficMeasurements">{{infoSpeceficMeasurements}}</span>
        <br />
        <br />
        <br />
        <button class="get" @click="showRecentMeasurements">Show recent Mesurements</button>
        <br />
        <span v-html="infoRecentMeasurements">{{infoRecentMeasurements}}</span>
        <br />
        <br />
        <button class="get" @click="showDateSpeceficMeasurements">Show date specefic Measurements</button>
        <br />
        <input type="text" v-model="day" placeholder="Enter day" />
        <input type="text" v-model="month" placeholder="Enter month" />
        <br />
        <span v-html="infoDateSpeceficMeasurements">{{infoDateSpeceficMeasurements}}</span>
        <br />

        <button class="get" @click="showDateRangeMeasurements">Show date range Measurements</button>
        <br />
        <input type="text" v-model="day1" placeholder="Enter day1" />
        <input type="text" v-model="month1" placeholder="Enter month1" />
        <input type="text" v-model="year1" placeholder="Enter year1" />
        <input type="text" v-model="day2" placeholder="Enter day2" />
        <input type="text" v-model="month2" placeholder="Enter month2" />
        <input type="text" v-model="year2" placeholder="Enter year2" />

        <br />
        <span v-html="infoDateRangeMeasurements">{{infoDateRangeMeasurements}}</span>
        <br />

        <div>
            <p v-if="isConnected">We're connected to the server!</p>
            <p>Message from server: "{{socketMessage}}"</p>
            <button @click="pingServer()">Ping Server</button>
        </div>

    </div>
</template>

<script>
    export default {
        name: 'Home',
        data: function () {
            return {
                isConnected: false,
                socketMessage: '',
                infoLocation: null,
                infoSpeceficLocation: null,
                infoSpeceficMeasurements: null,
                infoDateSpeceficMeasurements: null,
                infoRecentMeasurements: null,
                infoDateRangeMeasurements: null,
                infoMeasurements: null,
                locationId: null,
                measurementId: null,
                day: null,
                month: null,
                day1: null,
                month1: null,
                year1: null,
                day2: null,
                month2: null,
                year2: null,
                name: null,
                email: null,
                password: null,
                name1: null,
                name2: null,
                lat: null,
                long: null,
                email1: null,
                password1: null,
                message: "",
                response: 'Server has not yet replied.',
            }
        },
        sockets: {
            connect() {
                // Fired when the socket connects.
                this.isConnected = true;
            },

            disconnect() {
                this.isConnected = false;
            },

            // Fired when the server sends something on the "messageChannel" channel.
            messageChannel(data) {
                this.socketMessage = data
            }
        },
        methods: {
            HandleErrors: function (response) {
                if (!response.ok) {
                    throw Error(response.statusText);
                }
                return response;
            },
            pingServer() {
                // Send the "pingServer" event to the server.
                this.$socket.emit('pingServer', 'PING!')
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
            showLocations() {
                this.$http.get('https://localhost:44384/api/Locations', {
                    headers: {
                        'Access-Control-Allow-Origin': '*',
                    },
                }).then(response => {
                    this.infoLocation = response.data;
                })
            },
            showMeasurements() {
                this.$http.get('https://localhost:44384/api/Measurements', {
                    headers: {
                        'Access-Control-Allow-Origin': '*',
                    },
                }).then(response => {
                    this.infoMeasurements = response.data;
                })
            },
            showSpeceficLocations() {
                this.$http.get('https://localhost:44384/api/Locations/' + this.locationId, {
                    headers: {
                        'Access-Control-Allow-Origin': '*',
                    },
                }).then(response => {
                    this.infoSpeceficLocation = response.data;
                })
            },
            showSpeceficMeasurements() {
                this.$http.get('https://localhost:44384/api/Measurements/' + this.measurementId, {
                    headers: {
                        'Access-Control-Allow-Origin': '*',
                    },
                }).then(response => {
                    this.infoSpeceficMeasurements = response.data;
                })
            },
            showDateSpeceficMeasurements() {
                this.$http.get('https://localhost:44384/api/MeasurementsDateSpecific/DateSpecific?day=' + this.day + '&month=' + this.month, {
                    headers: {
                        'Access-Control-Allow-Origin': '*',
                    },
                }).then(response => {
                    this.infoDateSpeceficMeasurements = response.data;
                })
            },
            showDateRangeMeasurements() {
                this.$http.get('https://localhost:44384/api/MeasurementsDateRange/DateRange?day1=' + this.day1 + '&month1=' + this.month1 + '&year1=' + this.year1 + '&day2=' + this.day2 + '&month2=' + this.month2 + '&year2=' + this.year2, {
                    headers: {
                        'Access-Control-Allow-Origin': '*',
                    },
                }).then(response => {
                    this.infoDateRangeMeasurements = response.data;
                })
            },
            showRecentMeasurements() {
                this.$http.get('https://localhost:44384/api/MeasurementsRecent/Recent', {
                    headers: {
                        'Access-Control-Allow-Origin': '*',
                    },
                }).then(response => {
                    this.infoRecentMeasurements = response.data;
                })
            },
        },
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

