public class PersonagemGame {

    private int saudeAtual;
    private String nome;
    private String status;


    public PersonagemGame(int saudeAtual, String nome) {
        this.setSaudeAtual(saudeAtual);
        this.setNome(nome);
    }
    public int getSaudeAtual() {
        return saudeAtual;
    }

    public void setSaudeAtual(int saudeAtual) {
        this.saudeAtual = saudeAtual;
        if (this.saudeAtual  > 0) {
            status = "vivo";
        }  else if (this.saudeAtual  <= 0) {
            status = "morto";
        }
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        if (nome != null && !nome.isBlank()){
            this.nome = nome;
        }
    }

    public String getStatus() {
        return status;
    }

    public void tomarDano (int quantidadeDeDano) {
        if ((saudeAtual - quantidadeDeDano) >= 0) {
            setSaudeAtual(saudeAtual -= quantidadeDeDano);
        } else {
            setSaudeAtual(0);
        }
    }

    public void receberCura (int quantidadeDeCura) {
        if ((saudeAtual + quantidadeDeCura) <= 100) {
            setSaudeAtual(saudeAtual += quantidadeDeCura);
        } else {
            setSaudeAtual(100);
        }
    }

}
