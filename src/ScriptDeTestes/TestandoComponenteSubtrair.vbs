Rem Mensagem informativa
Msgbox "Teste de Subtracao"

Rem Cria a variavel
Dim obj 

Rem Inicia o objeto COM
Set obj = CreateObject("MatematicaServer.Matematica")

Rem Captura os Valores
intPrimeiro = inputbox("Digite um inteiro para o Primeiro Valor")
intSegundo = inputbox("Digite um inteiro para o Segundo Valor")

Rem Chama o Objeto COM e retorna o resultado
Msgbox "O valor retornado e " & obj.Subtrair(intPrimeiro,intSegundo)