<template>
	<div id="card-login" class="card">
		<div class="card-body">
			<img src="./assets/images/LOGOTIPO.png" class="card-img-top text-center" alt="Logotipo da CIMATECJr">
			<h5 class="card-title">SISTEMA DE GESTÃO INTERNA</h5>
			<form>
			  <div class="form-group">
			    <label for="exampleInputEmail1" class="form-login">Email</label>
			    <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp">
			  </div>
			  <div class="form-group">
			    <label for="exampleInputPassword1" class="form-login">Senha</label>
			    <input type="password" class="form-control" id="exampleInputPassword1">
			  </div>
			  <button type="submit" class="btn btn-light btn-login float-right">Entrar</button>
			</form>
		</div>
	</div>
</template>

<script>


export default {
  	data () {
		return {
			msg: 'Welcome to Your Vue.js App'
		}
  	}
};
</script>


<style>

#card-login{
    max-width: 25rem;
    background-color:#FFFFFF;
    opacity: 0.7;
    margin-top: 100px;
    margin-left: 750px;
}

.card-title{
    color:#000000;
    text-align: center;
    font-family: 'Noto Sans HK', sans-serif;
}

.card-img-top{
    width: 15rem;
    display: block;
    margin-left: auto;
    margin-right: auto;
}

.form-login{
    font-size:15px;
    font-family: 'Noto Sans HK', sans-serif;
    color: #000000;

}

.btn .btn-light .btn-login{
    margin-right: 200px;
    align-self: right;
}
</style>
