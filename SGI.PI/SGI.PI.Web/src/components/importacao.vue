<template>
    <div>
        <navbar-component v-bind:isTelaPrincipal="false"></navbar-component>
            <div class="container main-container">
                <div class="txt-align">            
                    <h3>Importação</h3>
                    <div class="line"></div>
                    <div class="space-line"> </div>
                    <div class="col-sm-12">
                        <div class="table-responsive">
                            <table class="table">
                                <thead>
                                    <tr>
                                        <th>
                                            <input type="file"> 
                                        </th>
                                        <th>
                                            <a href="#" >
                                                <font-awesome-icon style="font-size: 30px; color: Dodgerblue;" icon="plus-circle"></font-awesome-icon>
                                            </a>

                                        </th>
                                    </tr>
                                </thead>
                            </table>
                        </div>
                    </div>
                    <!-- barra de progresso -->
                    <div class="space-line"></div>
                    <div class="space-line"></div>

                    <h5 class="form-section">Arquivos Importados</h5>
                    <div class="row">
                        <div class="col-sm-12">
                            <div class="table-responsive">
                                <table class="table">
                                    <thead>
                                        <tr>
                                            <th>Arquivo</th>
                                            <th>Data Importação</th>
                                            <th>Responsável</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <!-- <tr v-for=" item in arquivosImportados" :key="item.id">
                                            <td>
                                                {{ item.nome }}
                                            </td>
                                            <td>
                                                {{ item.versao || 'Não Informada' }}
                                            </td>
                                            <td>
                                                {{ item.dataImportacao }}
                                            </td>
                                            <td>
                                                {{ item.nomeResponsavel || item.emailResponsavel }}
                                            </td>
                                        </tr> -->
                                    </tbody>
                                </table>
                            </div>

                        </div>
                </div>

            </div>
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

.main-container{
    max-width: 1200px;
    height: 520px;
    margin-top: 10px;
    text-align: center;
    display: inline-block;
    background-color: white;
}

.txt-align{
    text-align: left;
    margin-left: 20px;
    margin-top: 20px;
}

.line {
    max-width: 1150px;
    height: 17px;
    border-bottom: 5px solid #becde5;
    position:relative;
}

.space-line {
    max-width: 1150px;
    height: 20px;
    position:relative;
}

.table-responsive{
    font-size:80%;
}

</style>
