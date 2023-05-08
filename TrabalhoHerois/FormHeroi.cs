﻿using System;
using System.Windows.Forms;

namespace TrabalhoHerois
{
    public partial class FormHeroi : Form
    {
        //Instancia a classe de metodos
        Methods met = new Methods();

        public FormHeroi()
        {
            InitializeComponent();
        }
        //Ao clicar nesse Botão é pego todas as informações contidas dentro dos textbox
        //e registra no banco de dados
        #region cadastro de informação
        private void bt_enviar_Click(object sender, EventArgs e)
        {

        }
        #endregion

        //Ao clicar no Botão chama o metodo que faz o upload de uma imagem a escolha do usuario
        #region upload de imagem
        private void btUpload_Click(object sender, EventArgs e)
        {
            //Chama o metodo que faz o upload da imagem ao picturebox
            met.uploadImage(pbFoto);
        }
        #endregion

        //Chama o metodo que ao sair do textbox e perder o 'focar' do texto retorna o
        //texto que esta contido na tag de volta ao textbox
        #region placeholder's enter
        //PRIMEIRO NOME
        private void tbNome_Leave(object sender, EventArgs e)
        {
            met.addText(tbNome, tbNome.Tag.ToString());
        }
        //ÚLTIMO NOME
        private void tbSobreNome_Leave(object sender, EventArgs e)
        {
            met.addText(tbSobreNome, tbSobreNome.Tag.ToString());
        }
        //EMAIL
        private void tbEmail_Leave(object sender, EventArgs e)
        {
            met.addText(tbEmail, tbEmail.Tag.ToString());
        }
        //PLANETA DE ORIGEM
        private void tbPlaneta_Leave(object sender, EventArgs e)
        {
            met.addText(tbPlaneta, tbPlaneta.Tag.ToString());
        }
        //SUPER PODER
        private void tbPoder_Leave(object sender, EventArgs e)
        {
            met.addText(tbPoder, tbPoder.Tag.ToString());
        }
        //PARCEIRO
        private void tbParceiro_Leave(object sender, EventArgs e)
        {
            met.addText(tbParceiro, tbParceiro.Tag.ToString());
        }
        //APELIDO DO HEROI
        private void tbApelido_Leave(object sender, EventArgs e)
        {
            met.addText(tbApelido, tbApelido.Tag.ToString());
        }
        //ATIVIDADE PROFISSIONAL
        private void tbAtiPro_Leave(object sender, EventArgs e)
        {
            met.addText(tbAtiPro, this.Tag.ToString());
        }
        //GRUPO DO HEROI
        private void tbGrupo_Leave(object sender, EventArgs e)
        {
            met.addText(tbGrupo, tbGrupo.Tag.ToString());
        }
        //FRAQUEZA DO HEROI
        private void tbFraco_Leave(object sender, EventArgs e)
        {
            met.addText(tbFraco, tbFraco.Tag.ToString());
        }
        #endregion

        //Chama o metodo que ao entrar no textbox e ganhar o 'foco' do texto apaga o
        //texto que estava contido dentro do textbox, desde que não seja o texto do usuario
        #region placeholder's clear
        //PRIMEIRO NOME
        private void tbNome_Enter(object sender, EventArgs e)
        {
            met.clearText(tbNome);
        }
        //ÚLTIMO NOME
        private void tbSobreNome_Enter(object sender, EventArgs e)
        {
            met.clearText(tbSobreNome);
        }
        //EMAIL
        private void tbEmail_Enter(object sender, EventArgs e)
        {
            met.clearText(tbEmail);
        }
        //PLANETA DE ORIGEM
        private void tbPlaneta_Enter(object sender, EventArgs e)
        {
            met.clearText(tbPlaneta);
        }
        //SUPER PODER
        private void tbPoder_Enter(object sender, EventArgs e)
        {
            met.clearText(tbPoder);
        }
        //PARCEIRO
        private void tbParceiro_Enter(object sender, EventArgs e)
        {
            met.clearText(tbParceiro);
        }
        //APELIDO DO VILÃO
        private void tbApelido_Enter(object sender, EventArgs e)
        {
            met.clearText(tbApelido);
        }
        //ATIVIDADE PROFISSIONAL
        private void tbAtiPro_Enter(object sender, EventArgs e)
        {
            met.clearText(tbAtiPro);
        }
        //NOME DO GRUPO
        private void tbGrupo_Enter(object sender, EventArgs e)
        {
            met.clearText(tbGrupo);
        }
        //FRAQUEZA DO HEROI
        private void tbFraco_Enter(object sender, EventArgs e)
        {
            met.clearText(tbFraco);
        }
        #endregion
    }
}