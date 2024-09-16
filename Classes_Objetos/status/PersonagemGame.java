public class PersonagemGame {
    private int saudeAtual;
    private String nome;
    private String status;


    public int getSaudeAtual() {
        return saudeAtual;
    }

    public int setSaudeAtual(int saudeAtual) {
        this.saudeAtual = saudeAtual;
        if (this.saudeAtual  > 0) {
            status = "vivo";
        } else if (this.saudeAtual  > 100) {
            this.saudeAtual = 100;
        } else if (this.saudeAtual  <= 0) {
            status = "morto";
            this.saudeAtual = 0;
        }
        return saudeAtual;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getStatus() {
        return status;
    }

    public int tomarDano(int quantidadeDeDano){
        return setSaudeAtual(saudeAtual-quantidadeDeDano);
    }

    public int receberCura(int quantidadeDeCura){

        return setSaudeAtual(saudeAtual + quantidadeDeCura);
    }
}
