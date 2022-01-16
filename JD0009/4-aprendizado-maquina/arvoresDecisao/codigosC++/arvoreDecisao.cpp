/*%****************************************************************************80
%  Code: 
%   arvoreDecisao.cpp
%
%  Purpose:
%   Decision Tree Algorithm in C++
%
%  Modified:
%   Jul 25 2021 16:34 
%
%  Author:
%   Murilo Do Carmo Boratto [muriloboratto@uneb.br]  
%   
%  How to Compile:
%   g++ arvoreDecisao.cpp -o object 
%   
%  How to Execute:
%   ./object <file.csv>
%   ./object praia.csv
%
%  Comments:
%    - Decision Tree example from : https://github.com/chr0m1ng/decisionTree.git 
%
%    - The algorithm generates a decision tree based on entropy calculation.
%       This algorithm works for any input that meets the following patterns:
%       Must have a maximum of two responses per attribute, all attributes and responses must be different,
%       i.e., there cannot exist two characteristics with the same name or two other answers with the same name
%  
%******************************************************************************/

#include <iostream>
#include <vector>
#include <cmath>
#include <cstring>
#include <fstream>
#include <sstream>

using namespace std;

#define h 14
#define p 6
#define espaco 11

bool visto[p - 1] = {false};

typedef struct tPos
{
    int i;
    int j;
}tPos;

typedef struct atrib
{
    int sim;
    int nao;
    int total;
    float prob;
    string nome;
}tAtributo;

typedef struct tCampo
{
    string valor;
    bool checar;
    string pergunta;
    int nivel;
}tCampo;

typedef struct arv
{
    struct atrib atributos[p][2]; 
    string nomeAtributo;
    string nomeResposta; 
    struct arv *esq;
    struct arv *dir;
}tArvore;

vector<string> questoes;

vector<string> quebra(string input, char div)
{
    stringstream test;
    test << input;
    string segment;
    vector<string> seglist;

    while(getline(test, segment, div))
        seglist.push_back(segment);

    return seglist;
}

tPos achaAttPos(string nome, tArvore* no)
{
    tPos out;
    out.i = 0;
    out.j = 0;
    for(int i = 0; i < p; i++)
    {
        for(int j = 0; j < 2; j++)
        {
            if(no->atributos[i][j].nome == nome)
            {
                out.i = i;
                out.j = j;
                return out;
            }

        }
    }
}


void criaAtributos(tArvore *no, tCampo **tabela)
{
    for(int i = 0; i < p; i++)
    {
        for(int j = 0; j < 2; j++)
        {
            no->atributos[i][j].sim = 0;
            no->atributos[i][j].nao = 0;
            no->atributos[i][j].total = 0;
            no->atributos[i][j].prob = 0.0;
        }
    }
    for(int j = 0; j < p; j++)
    {
        no->atributos[j][0].nome = tabela[0][j].valor;
        for(int i = 0; i < h; i++)
        {
            if(no->atributos[j][0].nome != tabela[i][j].valor)
            {
                no->atributos[j][1].nome = tabela[i][j].valor;
                break;
            }
        }
    }
}

void zeraAtributos(tArvore *no)
{
    for(int i = 0; i < p; i++)
    {
        for(int j = 0; j < 2; j++)
        {
            no->atributos[i][j].sim = 0;
            no->atributos[i][j].nao = 0;
            no->atributos[i][j].total = 0;
            no->atributos[i][j].prob = 0.0;
        }
    }
}


void printaAtributos(tArvore *no)
{
    for(int i = 0; i < p; i++)
    {
        cout << questoes[i] << endl << endl;

        cout << "\t\t\t\t Sim \t\t\t\t Nao \t\t\t\t Total" << endl;
        cout << no->atributos[i][0].nome << "\t\t\t\t" << no->atributos[i][0].sim << "\t\t\t\t" << no->atributos[i][0].nao << "\t\t\t\t" << no->atributos[i][0].total << endl;
        cout << no->atributos[i][1].nome << "\t\t\t\t" << no->atributos[i][1].sim << "\t\t\t\t" << no->atributos[i][1].nao << "\t\t\t\t" << no->atributos[i][1].total << endl;

        cout << endl << endl; 
    }
}


void calcAtt(tCampo **tabela, tArvore *no, int nivel)
{
    zeraAtributos(no);

    for(int i = 0; i < h; i++)
    {
        if(tabela[i][0].nivel == nivel)
        {
            for(int j = 0; j < p - 1; j++)
            {   
                tPos att = achaAttPos(tabela[i][j].valor, no); 
                if(tabela[i][p - 1].valor == no->atributos[p - 1][0].nome)
                {
                    no->atributos[att.i][att.j].sim++;
                    no->atributos[att.i][att.j].total++;
                }
                else
                {
                    no->atributos[att.i][att.j].nao++;
                    no->atributos[att.i][att.j].total++;
                }
            }
            if(tabela[i][p - 1].valor == no->atributos[p - 1][0].nome)
            {
                no->atributos[p - 1][0].sim++;
                no->atributos[p - 1][0].total++;
                no->atributos[p - 1][1].total++;
            }
            else
            {
                no->atributos[p - 1][1].sim++;
                no->atributos[p - 1][0].total++;
                no->atributos[p - 1][1].total++;
            }
        }
    }
    

    for(int i = 0; i < p - 1; i++)
    {
        for(int j = 0; j < 2; j++)
        {
            if(no->atributos[i][j].total && log2((float)no->atributos[i][j].sim / no->atributos[i][j].total) && log2((float)no->atributos[i][j].nao / no->atributos[i][j].total))
                no->atributos[i][j].prob = (-1 * ((float)no->atributos[i][j].sim / no->atributos[i][j].total)) * log2((float)no->atributos[i][j].sim / no->atributos[i][j].total) + (-1 * ((float)no->atributos[i][j].nao / no->atributos[i][j].total)) * log2((float)no->atributos[i][j].nao / no->atributos[i][j].total);
            else
                no->atributos[i][j].prob = 0.0;
        }
    }
    
}


void printaTabela(tCampo **tabela)
{
    for(int i = 0; i < p; i++)
        cout << questoes[i] << "\t\t\t";
    cout << endl;
    for(int i = 0; i < h; i++)
    {
        if(tabela[i][0].checar)
            for(int j = 0; j < p; j++)
                cout << tabela[i][j].valor << "\t\t\t\t";
        cout << endl;
    }
}

void resetaTabela(tCampo **tabela)
{
    for(int i = 0; i < h; i++)
        tabela[i][0].checar = true;
}

int achaMaiorProb(double *probs)
{
    int maior;

    for(int i = 0; i < p - 1; i++)
        if(visto[i] == false)
            maior = i;

    for(int i = 0; i < p - 1; i++)
        if(visto[i] == false && probs[i] >= probs[maior])
            maior = i;

    return maior;
}          

void calcEntropia(double *probs, tArvore *no)
{
    if(no->atributos[p - 1][0].total && log2((float)no->atributos[p - 1][0].sim / no->atributos[p - 1][0].total) && log2((float)no->atributos[p - 1][1].sim / no->atributos[p - 1][0].total))
        probs[p - 1] = (-1 * ((float)no->atributos[p - 1][0].sim / no->atributos[p - 1][0].total)) * log2((float)no->atributos[p - 1][0].sim / no->atributos[p - 1][0].total) + (-1 * ((float)no->atributos[p - 1][1].sim / no->atributos[p - 1][0].total)) * log2((float)no->atributos[p - 1][1].sim / no->atributos[p - 1][0].total);
    else
        probs[p - 1] = 0;
    for(int i = 0; i < p - 1; i++)
        probs[i] = probs[p - 1] - (((float)no->atributos[i][0].total / (float)no->atributos[p - 1][0].total) * no->atributos[i][0].prob + ((float)no->atributos[i][1].total / (float)no->atributos[p - 1][0].total) * no->atributos[i][1].prob);
}

void especializar(tCampo **tabela, tArvore *no, int nivel, int maior, int aux)
{
    for(int i = 0; i < h; i++)
        if(tabela[i][0].nivel == nivel)
            for(int j = 0; j < p; j++)
                if(tabela[i][j].valor == no->atributos[maior][aux].nome)
                    tabela[i][0].nivel++;
}

void desespecializar(tCampo **tabela, int nivel)
{
    for(int i = 0; i < h; i++)
        if(tabela[i][0].nivel == nivel + 1)
            tabela[i][0].nivel--;
}

void resolve(tArvore *no, tCampo **tabela, int nivel)
{
    double entropia[p];
    int maior;

    criaAtributos(no, tabela);


    calcAtt(tabela, no, nivel);

    if(no->atributos[p - 1][0].total == 0)
        return;

    if(no->atributos[p - 1][0].sim == no->atributos[p - 1][0].total || no->atributos[p - 1][1].sim == no->atributos[p - 1][0].total)
    {
        
        if(no->atributos[p - 1][0].sim == no->atributos[p - 1][0].total)
            no->nomeAtributo = no->atributos[p - 1][0].nome;
        else
            no->nomeAtributo = no->atributos[p - 1][1].nome;

        no->esq = NULL;
        no->dir = NULL;
        return;
    }

    calcEntropia(entropia, no);
    maior = achaMaiorProb(entropia);

    no->nomeAtributo = questoes[maior];
    visto[maior] = true;

    no->esq = new tArvore[1];
    no->esq->nomeResposta = no->atributos[maior][0].nome;
    no->esq->esq = NULL;
    no->esq->dir = NULL;
    especializar(tabela, no, nivel, maior, 0);
    resolve(no->esq, tabela, nivel + 1);
    desespecializar(tabela, nivel);

    no->dir = new tArvore[1];
    no->dir->nomeResposta = no->atributos[maior][1].nome;
    no->dir->esq = NULL;
    no->dir->dir = NULL;
    especializar(tabela, no, nivel, maior, 1);
    resolve(no->dir, tabela, nivel + 1);
    desespecializar(tabela, nivel);

    visto[maior] = false;
}

void desenha_arvore_horiz(tArvore *arvore, int depth, char *path, int direita){
    if (arvore == NULL)
        return;

    depth++;
    desenha_arvore_horiz(arvore->dir, depth, path, 1);
    path[depth-2] = 0;

    if(direita)
        path[depth-2] = 1;

    if(arvore->esq)
        path[depth-1] = 1;

    printf("\n\t");

    for(int i=0; i<depth-1; i++){
      if(i == depth-2)
          printf("+");
      else if(path[i])
          printf("|");
      else
          printf(" ");

      for(int j=1; j<espaco; j++)
		  if(i < depth-2)
			  printf(" ");
		  else
			  printf("-");
    }

    cout << " " << arvore->nomeResposta << "(" << arvore->nomeAtributo << ")" << endl << "\t";

    for(int i=0; i<depth; i++) {
      if(path[i])
          printf("|");
      else
          printf(" ");

      for(int j=1; j<espaco; j++)
          printf(" ");
    }

    desenha_arvore_horiz(arvore->esq, depth, path, 0);
}


void draw_arvore_hor(tArvore *arvore) {
    char path[255] = {};
    desenha_arvore_horiz(arvore, 0, path, 0);
    cout << endl << endl;
}

void libera_NO(tArvore* no){
    if(no == NULL)
        return;
    libera_NO(no->esq); //libera todos da esquerda
    libera_NO(no->dir); //libera todos da direita
    delete [] no; //libero ele
    no = NULL;
}

/*************************************************************************************************************/

int main(int argc, char **argv){

    string file = argv[1];

    string line;
    string arq;
    string questao;
    ifstream myfile;
    vector<string> linhas;
    tCampo **tabela;

    tabela = new tCampo*[h];
    for(int i = 0; i < h; i++)
        tabela[i] = new tCampo[p];
    

    myfile.open(file);
      

    if (myfile.is_open())
    {
        getline (myfile, questao);
        questoes = quebra(questao, ',');

        for (int i = 0; i < h; i++)
        {
            getline(myfile, line);
            linhas = quebra(line, ',');
            for(int j = 0; j < p; j++)
            {
                tabela[i][j].valor = linhas[j];
                tabela[i][j].checar = true;
                tabela[i][j].pergunta = questoes[j];
                tabela[i][j].nivel = 0;
            }
        }
        myfile.close();
    }
    else 
        cout << "Erro ao abrir arquivo" << endl;
    
    tArvore *no;

    //Raiz
    no = new tArvore[1];

    no->nomeResposta = "";
    no->esq = NULL;
    no->dir = NULL;

    resolve(no, tabela, 0);

    draw_arvore_hor(no);

    libera_NO(no);

    return 0;

}/*main*/
