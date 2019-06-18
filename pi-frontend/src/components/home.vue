<template>
    <div>
        <navbar-component v-bind:isTelaPrincipal="true"></navbar-component>
        
        <div>
            <b-container class="wrapper">
                <b-row>
                    <b-col class="wrapper-cols">
                        <b-button class="btn-tela-principal">Importar membros</b-button>
                    </b-col>
                    <b-col class="wrapper-cols">
                        <b-button class="btn-tela-principal">Ver membros</b-button>
                    </b-col>
                    <b-col class="wrapper-cols">
                        <b-button class="btn-tela-principal">People Analytics</b-button>
                    </b-col>
                    <b-col class="wrapper-cols">
                        <b-button class="btn-tela-principal">People Analytics</b-button>
                    </b-col>
                </b-row>
            </b-container>
        </div>
    </div>
</template>


<script>

import NavBar from './navbar-component'

export default {
    components: {
        'navbar-component': NavBar,
    },
};
</script>

<style>
body,
html{
    margin:  0; 
    padding: 0;
    font-size:18px;
    font-family: 'Noto Sans HK', sans-serif;
}
body{
    background-color: #becde5;  
    background-size:100%;
    background-attachment:fixed;
}
.wrapper {
  text-align: center;
    margin-left:auto;
    margin-right:auto;
    margin-top: 100px;
}

.wrapper-cols{
    margin-right: 10px;
    margin-top: 10px;
}

.btn-tela-principal{
    width: 200px;
    height: 90px;
    background-color: #286bd6;
}

.btn-tela-principal:hover{
    background-color: #FFFFFF;
    color: black;
}

</style>

