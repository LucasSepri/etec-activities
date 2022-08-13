import  React,{ useState } from 'react';
import { StyleSheet, Text, View, TextInput, TouchableOpacity }
from 'react-native';
import Cep from'./components/Cep';
import Api from'./components/Api';


export default function App()
{ 
	const[cep,setCep] = useState(0); 
	const[inputCep,setInputCep] = useState(0); 
	async function carregaCep(){
		const response = await Api.get('ws/'+inputCep+'/json/');
		setCep (response.data);
	}
	
	
  return (
		<View style={styles.container}>
			<View style={styles.blobo}>
				<Text style={styles.textoBloco}>
					Digite seu cep:
				</Text>
				<TextInput
					placeholder="Digite seu cep ..."
					style={styles.input}
					onChangeText={(data)=>setInputCep(data)}
				/>

				<TouchableOpacity style={styles.botao}
					onPress={carregaCep}
					>
					<Text style={styles.textoB}>Buscar</Text>
				</TouchableOpacity>
			<Cep data={cep}/>
		  </View>
	  </View>		
	);
 }


const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },
	bloco:{
		witdh:'100%'
	},
	  
	input:{
		width:'80%',
		marginLeft:'10%',
		borderBottomWidth:1,
		fontSize:20
	},
	texto:{
		fontSize:20,
		textAlign:'center'
	},
	botao:{
		width:'80%',
		marginLeft:'10%'
	},
	textoBotao:{
		fontSize:20,
		textAlign:'center'
	},
	  
});