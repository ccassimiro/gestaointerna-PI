<template>
    <div role="navigation" class="navbar navbar-light  navbar-expand-lg">
            <a class="navbar-brand" href="#">
                <img class="img-logotipo" src="./assets/images/engrenagem.png">
                Sistema de Gestão Interna
            </a>

            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul class="navbar-nav ml-auto">
                <li v-if="!isTelaPrincipal" class="nav-item">
                    <a class="nav-link" href="#">Membros</a>
                </li>
                <li v-if="!isTelaPrincipal" class="nav-item">
                    <a class="nav-link" href="#">Relatórios</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">Oi, Fulano!</a>
                </li>
                
                </ul>
            </div>	
        </div>
</template>


<script>
export default {
    props: {
        isTelaPrincipal: Boolean,
    },
    data(){
        return{
        }
    },
    computed : {
        
    }
}
</script>


<style>
.img-logotipo{
    width: 2rem;
}

.navbar {
    margin-top:-50px;
    background-color: #FFFFFF;
}

.nav-item{
    margin-left: 15px;
    margin-right: 15px;
    color: #FFFFFF;
}

.nav-item:hover{
    border-radius: 15px;
    background-color: #becde5;
    margin-left: 15px;
    margin-right: 15px;
}
</style>
