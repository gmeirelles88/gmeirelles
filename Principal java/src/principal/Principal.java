/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package principal;

/**
 *
 * @author Gabriel
 */
public class Principal {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Geladeira geladeiraHerdada = new Geladeira();
        Televisao televisaoHerdada = new Televisao();
        AparelhoSom aparelhoHerdado = new AparelhoSom();
        
        geladeiraHerdada.setCor("Branca");
        /*geladeiraHerdada.setClassificacaoConsumo("Produto Verde");*/
        televisaoHerdada.setTamanho(45);
        televisaoHerdada.setVoltagem(110);
        aparelhoHerdado.setMarca("Rádio Vanguarda");
        
        String var1 = geladeiraHerdada.descongelar();
        /*String var1.1 = geladeiraherdada.*/
        String var2 = televisaoHerdada.ligar();
        String var3 = televisaoHerdada.mudarCanal();
        String var4 = aparelhoHerdado.mudarEstacao();
        
        System.out.println(
                var1 + "\n" +
                var2 + "\n" +
                var3 + "\n"+        
                var4 + "\n"        
        );
        
    }
    
}

