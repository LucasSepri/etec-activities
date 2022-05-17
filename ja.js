function CalcVm() {
	var resultado, distancia, tempo;

	distancia = parseInt(document.getElementById('distancia').value);
	tempo = parseInt(document.getElementById('tempo').value);

	resultado = distancia / tempo;

	document.getElementById('mostra').innerHTML = 
	"O Valor da Velocidade Média é: " + resultado;
}
