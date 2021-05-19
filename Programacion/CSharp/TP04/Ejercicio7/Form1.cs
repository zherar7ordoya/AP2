﻿using System;
using System.Windows.Forms;

namespace Listas2017 {
  public partial class Form1 : Form {

    // *------------------------------------------------------=> INICIALIZACIÓN
    ListaEnlazadaSimple miListaEnlazadaSimple = new ListaEnlazadaSimple();
    NodoSimple nodoSeleccionado, nodo1, nodo2;
    public Form1() { InitializeComponent(); }
    private void Form1_Load(object sender, EventArgs e) {  GenerarLista(); }

    // *-----------------------------------------------------------=> CONTROLES

    private void listaNodos_SelectedIndexChanged(object sender, EventArgs e) {
      nodoSeleccionado = (NodoSimple)this.listaNodos.SelectedItem;

      if (listaNodos.SelectedItems.Count == 2) {
        nodo1 = (NodoSimple)listaNodos.SelectedItems[0];
        nodo2 = (NodoSimple)listaNodos.SelectedItems[1];
      }

    }

    private void cmdAgregarAlPrincipio_Click(object sender, EventArgs e) {
      miListaEnlazadaSimple.AgregarAlPrincipio(this.textBox1.Text);
      GenerarLista();
    }

    private void cmdAgregarAlFinal_Click(object sender, EventArgs e) {
      miListaEnlazadaSimple.AgregarAlFinal(this.textBox1.Text);
      GenerarLista();
    }

    private void btnQuitarSeleccionado_Click(object sender, EventArgs e) {
      if (nodoSeleccionado != null) {
        miListaEnlazadaSimple.QuitarPosicion(nodoSeleccionado.Numero);
        GenerarLista();
      }
      else { MessageBox.Show("debe seleccionar un nodo."); }
    }

    private void btnQuitarPrimero_Click(object sender, EventArgs e) {
      miListaEnlazadaSimple.QuitarPrimero();
      GenerarLista();
    }

    private void btnQuitarUltimo_Click(object sender, EventArgs e) {
      miListaEnlazadaSimple.QuitarUltimo();
      GenerarLista();
    }

    ////////////////////////////////////////////////////////////// USER STORIES

    private void btnIntercambiarDerecha_Click(object sender, EventArgs e) {
      miListaEnlazadaSimple.IntercambiarDerecha(nodoSeleccionado.Numero);
      GenerarLista();
    }

    private void btnIntercambiarIzquierda_Click(object sender, EventArgs e) {
      miListaEnlazadaSimple.IntercambiarIzquierda(nodoSeleccionado.Numero);
      GenerarLista();
    }

    private void btnIntercambiar_Click(object sender, EventArgs e) {
      miListaEnlazadaSimple.Intercambiar(nodo1.Numero, nodo2.Numero);
      GenerarLista();
    }

    ///////////////////////////////////////////////////////////////// FUNCIONES

    private void GenerarLista() {
      this.listaNodos.Items.Clear();
      Listar(miListaEnlazadaSimple.NodoInicial);
    }

    // *----------------------------------------------=> FUNCIONES DE FUNCIONES
    private void Listar(NodoSimple nodo) {
      if (nodo != null) {
        listaNodos.Items.Add(nodo);
        if (nodo.Siguiente != null) { Listar(nodo.Siguiente); }
      }
    }
    ///////////////////////////////////////////////////////////////////////////
  }
}
