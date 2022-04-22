namespace Sistemas_Vendas
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Estoque = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.escolhaSeuProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.softwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.Estoque.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Estoque
            // 
            this.Estoque.BackColor = System.Drawing.Color.Indigo;
            this.Estoque.Controls.Add(this.textBox4);
            this.Estoque.Controls.Add(this.label7);
            this.Estoque.Controls.Add(this.label6);
            this.Estoque.Controls.Add(this.comboBox2);
            this.Estoque.Controls.Add(this.label5);
            this.Estoque.Controls.Add(this.comboBox1);
            this.Estoque.Controls.Add(this.textBox3);
            this.Estoque.Controls.Add(this.label3);
            this.Estoque.Controls.Add(this.textBox2);
            this.Estoque.Controls.Add(this.textBox1);
            this.Estoque.Controls.Add(this.toolStrip1);
            this.Estoque.Controls.Add(this.label4);
            this.Estoque.Controls.Add(this.label2);
            this.Estoque.Controls.Add(this.dateTimePicker1);
            this.Estoque.Location = new System.Drawing.Point(12, 25);
            this.Estoque.Name = "Estoque";
            this.Estoque.Size = new System.Drawing.Size(900, 673);
            this.Estoque.TabIndex = 0;
            this.Estoque.TabStop = false;
            this.Estoque.Text = "Estoque";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(132, 171);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(167, 20);
            this.textBox4.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Magenta;
            this.label7.Location = new System.Drawing.Point(289, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Selecione Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Magenta;
            this.label6.Location = new System.Drawing.Point(6, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Selecione Estado";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "",
            "São Paulo",
            "Rio de Janeiro\t",
            "Salvador\t",
            "Brasília\t",
            "Fortaleza\t\t",
            "Belo Horizonte\t",
            "Manaus\t",
            "Curitiba\t",
            "Recife\t",
            "Porto Alegre\t",
            "Belém\t",
            "Goiânia\t",
            "Guarulhos\t",
            "Campinas\t",
            "São Luís\t",
            "São Gonçalo\t",
            "Maceió\t",
            "Duque de Caxias\t",
            "Natal\t",
            "Campo Grande\t",
            "Teresina\t",
            "São Bernardo do Campo\t",
            "Nova Iguaçu\t",
            "João Pessoa\t",
            "Santo André\t",
            "Osasco\t",
            "São José dos Campos\t",
            "Jaboatão dos Guararapes\t",
            "Ribeirão Preto\t",
            "Uberlândia\t",
            "Sorocaba\t\t",
            "Aracaju\t",
            "Feira de Santana\t",
            "Cuiabá\t",
            "Joinville\t",
            "Juiz de Fora\t",
            "Londrina",
            "Aparecida de Goiânia\t",
            "Ananindeua\t",
            "Niterói\t",
            "Porto Velho\t",
            "Campos dos Goytacazes\t",
            "Belford Roxo\t",
            "Serra\t",
            "Caxias do Sul\t",
            "Vila Velha\t",
            "Florianópolis\t",
            "São João de Meriti\t",
            "Mauá\t",
            "Macapá",
            "São José do Rio Preto\t\t",
            "Santos",
            "Mogi das Cruzes\t",
            "Betim\t",
            "Diadema\t",
            "Campina Grande\t",
            "Jundiaí\t",
            "Maringá\t",
            "Montes Claros\t",
            "Carapicuíba\t",
            "Olinda\t",
            "Piracicaba",
            "Cariacica\t",
            "Bauru\t",
            "Rio Branco\t",
            "Anápolis\t",
            "São Vicente\t",
            "Vitória\t",
            "Caucaia\t",
            "Itaquaquecetuba\t",
            "Caruaru\t",
            "Pelotas\t",
            "Vitória da Conquista\t",
            "Canoas\t",
            "Franca\t",
            "Ponta Grossa\t",
            "Blumenau\t",
            "Petrolina\t",
            "Paulista\t",
            "Ribeirão das Neves\t",
            "Uberaba\t",
            "Boa Vista",
            "Cascavel\t",
            "Guarujá\t",
            "Taubaté\t",
            "Petrópolis\t",
            "Limeira\t",
            "Praia Grande\t",
            "São José dos Pinhais\t",
            "Santarém\t",
            "Mossoró",
            "Suzano\t",
            "Camaçari\t",
            "Governador Valadares",
            "Santa Maria\t",
            "Gravataí\t",
            "Taboão da Serra\t",
            "Várzea Grande\t",
            "Palmas\t",
            "Juazeiro do Norte\t",
            "Foz do Iguaçu\t",
            "103º\tSP\tSumaré\t262.308",
            "104º\tRJ\tVolta Redonda\t262.259",
            "105º\tSP\tBarueri\t259.555",
            "106º\tSP\tEmbu das Artes\t259.053",
            "107º\tPA\tMarabá\t257.062",
            "108º\tMG\tIpatinga\t255.266",
            "109º\tMA\tImperatriz\t252.320",
            "110º\tRS\tViamão\t251.033",
            "111º\tRS\tNovo Hamburgo\t248.251",
            "112º\tSP\tSão Carlos\t238.958",
            "113º\tRN\tParnamirim\t235.983",
            "114º\tRJ\tMagé\t233.634",
            "115º\tSP\tMarília\t230.336",
            "116º\tMG\tSete Lagoas\t229.887",
            "117º\tPR\tColombo\t229.872",
            "118º\tRJ\tMacaé\t229.624",
            "119º\tAL\tArapiraca\t229.329",
            "120º\tMG\tDivinópolis\t228.643",
            "121º\tSC\tSão José\t228.561",
            "122º\tRJ\tItaboraí\t227.168",
            "123º\tRS\tSão Leopoldo\t226.988",
            "124º\tSP\tAmericana\t226.970",
            "125º\tSP\tIndaiatuba\t226.602",
            "126º\tSP\tCotia\t225.306",
            "127º\tSP\tJacareí\t224.826",
            "128º\tSP\tAraraquara\t224.304",
            "129º\tSP\tPresidente Prudente\t220.599",
            "130º\tSP\tItapevi\t220.250",
            "131º\tCE\tMaracanaú\t219.749",
            "132º\tBA\tItabuna\t218.925",
            "133º\tBA\tJuazeiro\t216.588",
            "134º\tMG\tSanta Luzia\t214.830",
            "135º\tSP\tHortolândia\t212.527",
            "136º\tMT\tRondonópolis\t211.718",
            "137º\tMS\tDourados\t210.218",
            "138º\tRS\tRio Grande\t207.036",
            "139º\tES\tCachoeiro de Itapemirim\t206.973",
            "140º\tRS\tAlvorada\t205.683",
            "141º\tSC\tCriciúma\t204.667",
            "142º\tRJ\tCabo Frio\t204.486",
            "143º\tGO\tRio Verde\t202.221",
            "144º\tSC\tChapecó\t202.009",
            "145º\tSC\tItajaí\t201.557",
            "146º\tCE\tSobral\t199.750",
            "147º\tSP\tRio Claro\t198.413",
            "148º\tPE\tCabo de Santo Agostinho\t198.383",
            "149º\tRS\tPasso Fundo\t195.620",
            "150º\tSP\tAraçatuba\t191.662",
            "151º\tGO\tLuziânia\t191.139",
            "152º\tSP\tSanta Bárbara d\'Oeste\t189.233",
            "153º\tBA\tLauro de Freitas\t188.013",
            "154º\tPA\tCastanhal\t186.895",
            "155º\tRJ\tAngra dos Reis\t184.940",
            "156º\tRJ\tNova Friburgo\t184.460",
            "157º\tPA\tParauapebas\t183.352",
            "158º\tSP\tFerraz de Vasconcelos\t182.544",
            "159º\tGO\tÁguas Lindas de Goiás\t182.526",
            "160º\tBA\tIlhéus\t182.350",
            "161º\tRJ\tBarra Mansa\t179.697",
            "162º\tPR\tGuarapuava\t176.973",
            "163º\tSE\tNossa Senhora do Socorro\t174.974",
            "164º\tMA\tSão José de Ribamar\t172.402",
            "165º\tMG\tIbirité\t171.932",
            "166º\tRJ\tTeresópolis\t",
            "167º\tRJ\tMesquita",
            "168º\tTO\tAraguaína\t1",
            "169º\tSP\tFrancisco Morato\t",
            "170º\tSP\tItu\t",
            "171º\tSP\tItapecerica da Serra\t",
            "\tTimon\t",
            "\tPoços de Caldas\t",
            "\tJequié\t",
            "Linhares\t",
            "\tCaxias\t",
            "\tJaraguá do Sul\t",
            "\tPindamonhangaba\t",
            "\tBragança Paulista\t",
            "\tLages\t",
            "\tSão Caetano do Sul\t",
            "\tTeixeira de Freitas\t",
            "Itapetininga\t",
            "\tPalhoça\t",
            "\tAlagoinhas\t",
            "\t\tCamaragibe\t",
            "\tBarreiras",
            "\t\tValparaíso de Goiás\t",
            "\t\tParanaguá\t",
            "\tParnaíba\t",
            "\tAbaetetuba\t",
            "\tPatos de Minas\t",
            "\tMogi Guaçu\t",
            "\tFranco da Rocha\t",
            "\t\tPorto Seguro\t",
            "\t\tMaricá\t",
            "\t\tQueimados\t",
            "\tPouso Alegre\t",
            "Jaú"});
            this.comboBox2.Location = new System.Drawing.Point(444, 207);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Magenta;
            this.label5.Location = new System.Drawing.Point(6, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Segmentação";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Amazonas ",
            "Roraima ",
            " Amapá ",
            "Pará ",
            " Tocantins ",
            "Rondônia ",
            " Acre",
            "Maranhão ",
            " Piauí ",
            " Ceará ",
            "Rio Grande do Norte ",
            " Pernambuco ",
            " Paraíba ",
            "Sergipe ",
            " Alagoas ",
            " Bahia",
            "Mato Grosso ",
            "Mato Grosso do Sul ",
            " Goiás  ",
            "São Paulo",
            "Rio de Janeiro",
            "Espírito Santo",
            " Minas Gerais",
            "Paraná ",
            " Rio Grande do Sul ",
            " Santa Catarina"});
            this.comboBox1.Location = new System.Drawing.Point(162, 207);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(178, 134);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(519, 20);
            this.textBox3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Magenta;
            this.label3.Location = new System.Drawing.Point(6, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome Razão Social";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(65, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(65, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(168, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 20);
            this.textBox1.TabIndex = 6;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripLabel1,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(894, 37);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = global::Sistemas_Vendas.Properties.Resources.ferramenta;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 34);
            this.toolStripButton1.Text = "Manutenção do Sistema";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Sistemas_Vendas.Properties.Resources.download;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 34);
            this.toolStripButton2.Text = "Cadastre o Produto";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Sistemas_Vendas.Properties.Resources.download__1_;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 34);
            this.toolStripButton3.Text = "Lista de Fornecedores";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::Sistemas_Vendas.Properties.Resources.download__2_;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 34);
            this.toolStripButton4.Text = "Relatório de Vendas";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(144, 34);
            this.toolStripLabel1.Text = "Digíte o  Codígo de Barras";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.escolhaSeuProdutoToolStripMenuItem,
            this.toolStripSeparator2,
            this.softwareToolStripMenuItem,
            this.redesToolStripMenuItem,
            this.outrosToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::Sistemas_Vendas.Properties.Resources.download__3_;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 34);
            this.toolStripDropDownButton1.Text = "Menu de Opção";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Escolha seu Produtos";
            // 
            // escolhaSeuProdutoToolStripMenuItem
            // 
            this.escolhaSeuProdutoToolStripMenuItem.Name = "escolhaSeuProdutoToolStripMenuItem";
            this.escolhaSeuProdutoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.escolhaSeuProdutoToolStripMenuItem.Text = "Hardware";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // softwareToolStripMenuItem
            // 
            this.softwareToolStripMenuItem.Name = "softwareToolStripMenuItem";
            this.softwareToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.softwareToolStripMenuItem.Text = "Software";
            // 
            // redesToolStripMenuItem
            // 
            this.redesToolStripMenuItem.Name = "redesToolStripMenuItem";
            this.redesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.redesToolStripMenuItem.Text = "Redes";
            // 
            // outrosToolStripMenuItem
            // 
            this.outrosToolStripMenuItem.Name = "outrosToolStripMenuItem";
            this.outrosToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.outrosToolStripMenuItem.Text = "Outros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Magenta;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "CNPJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Magenta;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome da Empresa";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(212, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estoque";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 666);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Estoque);
            this.Name = "Form2";
            this.Text = "Estoque";
            this.Estoque.ResumeLayout(false);
            this.Estoque.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Estoque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem escolhaSeuProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem softwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
    }
}