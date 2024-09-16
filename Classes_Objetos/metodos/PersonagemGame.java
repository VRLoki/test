public class PersonagemGame {
    private int saudeAtual;
    private String nome;

    public int getSaudeAtual() {
        return saudeAtual;
    }

    public void setSaudeAtual(int saudeAtual) {
        this.saudeAtual = saudeAtual;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }


    public int tomarDano(int quantidadeDeDano){
        saudeAtual =  saudeAtual - quantidadeDeDano;
        if (saudeAtual <= 0) {
            return saudeAtual = 0;
        }
        return saudeAtual;
    }

    public int receberCura(int quantidadeDeCura){
        saudeAtual =  saudeAtual + quantidadeDeCura;

        if (saudeAtual >= 100) {
            return saudeAtual = 100;
        }
        return saudeAtual;
    }


}
