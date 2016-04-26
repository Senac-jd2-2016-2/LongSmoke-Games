﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stick_RPG_Fight
{
    class Contexto
    {
        
        public static Background Fundo = new Background();
        public static bool Fase1, Fase2, Fase3, Fase4; // qual fase usar

        public static void inicializar(ContentManager content, Menu M1, Audio AUDIO, Personagem P1, Botoes Botao,  Inimigo i1, Agua DefineAgua) // carregar imagens quando a fase começa (não no começo)
        {
            //Direito
            P1.imgSpriteSheetparado1 = content.Load<Texture2D>("spritesheet p1 parado1"); // só imagem, logo posso usar isso também pros inimigos.
            P1.imgSpriteSheetparado2 = content.Load<Texture2D>("spritesheet p1 parado2");
            P1.imgSpriteSheetandando = content.Load<Texture2D>("spritesheet p1 andando");
            P1.imgSpriteSheetATIRARarco = content.Load<Texture2D>("spritesheet p1 atirar (arco)");
            P1.imgSpriteSheetSACARarco = content.Load<Texture2D>("spritesheet p1 sacar arco");
            P1.imgSpriteSheetagachar1 = content.Load<Texture2D>("spritesheet p1 agachar1");
            P1.imgSpriteSheetagachar2 = content.Load<Texture2D>("spritesheet p1 agachar2");
            P1.imgSpriteSheetcorrendo = content.Load<Texture2D>("spritesheet p1 correndo");
            P1.imgSpriteSheetdefesa1 = content.Load<Texture2D>("spritesheet p1 defesa1");
            P1.imgSpriteSheetagachadoHIT = content.Load<Texture2D>("spritesheet p1 agachar hit");
            P1.imgSpriteSheetpular = content.Load<Texture2D>("spritesheet p1 pular1");
            P1.imgsoco1 = content.Load<Texture2D>("p1 - soco1");
            P1.imgsoco2C1 = content.Load<Texture2D>("p1 - soco2 combo1");
            P1.imgsoco3C1 = content.Load<Texture2D>("p1 - soco3 combo1");
            P1.imgjoelhada4C1 = content.Load<Texture2D>("p1 - joelhada4 combo1");

            //ESQUERDO
            P1.imgSpriteSheetparado1E = content.Load<Texture2D>("spritesheet p1 parado1 ESQUERDA"); // (E)
            P1.imgSpriteSheetandandoE = content.Load<Texture2D>("spritesheet p1 andando ESQUERDA");
            P1.imgSpriteSheetcorrendoE = content.Load<Texture2D>("spritesheet p1 correndo ESQUERDA");
            P1.imgSpriteSheetpularE = content.Load<Texture2D>("spritesheet p1 pular1 ESQUERDA");
            P1.imgSpriteSheetparado2E = content.Load<Texture2D>("spritesheet p1 parado2 ESQUERDA");
            P1.imgsoco1E = content.Load<Texture2D>("p1 - soco1 E");
            P1.imgsoco2C1E = content.Load<Texture2D>("p1 - soco2 combo1 E");
            P1.imgsoco3C1E = content.Load<Texture2D>("p1 - soco3 combo1 E");
            P1.imgjoelhada4C1E = content.Load<Texture2D>("p1 - joelhada4 combo1 E");

            Fundo.menu00fundo = content.Load<Texture2D>("menu1");
            Fundo.imgfase1 = content.Load<Texture2D>("fase de luta");
            Fundo.imgfundopoder = content.Load<Texture2D>("fundo poder");

            M1.imghistory = content.Load<Texture2D>("history");
            M1.imgcombate = content.Load<Texture2D>("combate");
            M1.imgintromenu_comtraçado = content.Load<Texture2D>("intro game");
            M1.imgintromenu_semtraçado = content.Load<Texture2D>("intro game sem traçado");
            //M1.imgpredio_do_P1 = content.Load<Texture2D>("predio");
            
            AUDIO.menusong = content.Load<Song>("Base4");
            AUDIO.combatesong = content.Load<Song>("Base1");
            AUDIO.PODERsong = content.Load<Song>("coração LENTO");

            //botoes statics
            Botao.imgcomercioOFF = content.Load<Texture2D>("comercioOFF");
            Botao.imgcomercioOFFTP = content.Load<Texture2D>("comercioOFFTP");
            Botao.imgcomercioON = content.Load<Texture2D>("comercioON");
            Botao.imghomeOFF = content.Load<Texture2D>("homeOFF");
            Botao.imghomeOFFTP = content.Load<Texture2D>("homeOFFTP");
            Botao.imghomeON = content.Load<Texture2D>("homeON");
            Botao.imgcombosOFF = content.Load<Texture2D>("COMBOS OFF");
            Botao.imgcombosOFFTP = content.Load<Texture2D>("COMBOS OFFTP");
            Botao.imgcombosON = content.Load<Texture2D>("COMBOS ON");

            
            // inimigo 1
            i1.imgAndarDi1 = content.Load<Texture2D>("i1 - andar DIREITA");
            i1.imgAndarEi1 = content.Load<Texture2D>("i1 - andar");
            i1.imgParadoi1 = content.Load<Texture2D>("i1 - parado");
            //D
            i1.imgDEFDi1 = content.Load<Texture2D>("i1 - defesaD");
            i1.imgFacaDi1 = content.Load<Texture2D>("FacaD");
            i1.imgAgacharDi1 = content.Load<Texture2D>("i1 - agacharD");
            i1.imgAgacharDEFDi1 = content.Load<Texture2D>("i1 - agachar defendendoD");
            i1.imgCaidoDi1 = content.Load<Texture2D>("i1 - caidoD");
            i1.imgJogarFacaDi1 = content.Load<Texture2D>("i1 - jogando facaD");
            i1.imgHit1Di1 = content.Load<Texture2D>("i1 - hit1D");
            i1.imgHit2Di1 = content.Load<Texture2D>("i1 - hit2D");
            i1.imgHit3Di1 = content.Load<Texture2D>("i1 - hit3D");
            i1.imgLevantarDi1 = content.Load<Texture2D>("i1 - levantarD");
            i1.imgATK1Di1 = content.Load<Texture2D>("i1 - ataque1D");
            i1.imgAgarrarDi1 = content.Load<Texture2D>("i1 - agarrarD");
            i1.imgRasteiraDi1 = content.Load<Texture2D>("i1 - rasteiraD");
            i1.imgPODERDi1 = content.Load<Texture2D>("i1 - poderD");
            i1.imgMORTEDi1 = content.Load<Texture2D>("i1 - morteD");
            //E
            i1.imgDEFEi1 = content.Load<Texture2D>("i1 - defesa");
            i1.imgFacaEi1 = content.Load<Texture2D>("FacaE");
            i1.imgAgacharEi1 = content.Load<Texture2D>("i1 - agachar");
            i1.imgAgacharDEFEi1 = content.Load<Texture2D>("i1 - agachar defendendo");
            i1.imgCaidoEi1 = content.Load<Texture2D>("i1 - caido");
            i1.imgJogarFacaEi1 = content.Load<Texture2D>("i1 - jogando faca");
            i1.imgHit1Ei1 = content.Load<Texture2D>("i1 - hit1");
            i1.imgHit2Ei1 = content.Load<Texture2D>("i1 - hit2");
            i1.imgHit3Ei1 = content.Load<Texture2D>("i1 - hit3");
            i1.imgLevantarEi1 = content.Load<Texture2D>("i1 - levantar");
            i1.imgATK1Ei1 = content.Load<Texture2D>("i1 - ataque1");
            i1.imgAgarrarEi1 = content.Load<Texture2D>("i1 - agarrar");
            i1.imgRasteiraEi1 = content.Load<Texture2D>("i1 - rasteira");
            i1.imgPODEREi1 = content.Load<Texture2D>("i1 - poder");
            i1.imgMORTEi1 = content.Load<Texture2D>("i1 - morte");

            

            P1.imgBARRA = content.Load<Texture2D>("BARRA");
            P1.imgSOBRE = content.Load<Texture2D>("SOBRE");
            P1.imgVIDA = content.Load<Texture2D>("VIDA");
            P1.imgENERGIA = content.Load<Texture2D>("ENERGIA");
            P1.imgMANA = content.Load<Texture2D>("MANA");
            P1.imgXP = content.Load<Texture2D>("xp");
            P1.imgXPT = content.Load<Texture2D>("xptotal");
            P1.imgpino = content.Load<Texture2D>("pino");

            DefineAgua.imgAgua = content.Load<Texture2D>("agua");
            DefineAgua.imgOndas = content.Load<Texture2D>("SSH");

            //JANELA SPRITES
            JANELA.J.imgbotaoArmasOFF = content.Load<Texture2D>("botao armas OFF");
            JANELA.J.imgbotaoArmasON = content.Load<Texture2D>("botao armas ON");
            JANELA.J.imgbotaoCombosOFF = content.Load<Texture2D>("botao combos OFF");
            JANELA.J.imgbotaoCombosON = content.Load<Texture2D>("botao combos ON");
            JANELA.J.imgbotaoComercioOFF = content.Load<Texture2D>("botao comercio OFF");
            JANELA.J.imgbotaoComercioON = content.Load<Texture2D>("botao comercio ON");
            JANELA.J.imgbotaoPetOFF = content.Load<Texture2D>("botao pet OFF");
            JANELA.J.imgbotaoPetON = content.Load<Texture2D>("botao pet ON");
            JANELA.J.imgbotaoPoderesOFF = content.Load<Texture2D>("botao poderes OFF");
            JANELA.J.imgbotaoPoderesON = content.Load<Texture2D>("botao poderes ON");
            JANELA.J.imgbotaoX = content.Load<Texture2D>("bX");
            JANELA.J.imgbotaoXred = content.Load<Texture2D>("bX red");
            JANELA.J.imgjanelacinzaopç1 = content.Load<Texture2D>("janela cinza (opç1)");
            JANELA.J.imgjanelacombo = content.Load<Texture2D>("janela combo");
            JANELA.J.imgjanelacomercio = content.Load<Texture2D>("janela comercio");

            //visual do poder lançado
            Poder_Visual.p.imgcirculo = content.Load<Texture2D>("poder");
        }
    }
}
