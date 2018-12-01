Public Class Form1
    Public Property SelectionStart As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AcceptButton = Button1
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        TextBox1.SelectionStart = TextBox1.Text.Length
        TextBox1.ScrollToCaret()
        TextBox1.Refresh()
    End Sub
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text &= Environment.NewLine + "Tu: " + TextBox2.Text

        If TextBox2.Text = "Hola" Or TextBox2.Text = "hola" Or TextBox2.Text = "Hola" Or TextBox2.Text = "Hola" Or TextBox2.Text = "Oye" Or TextBox2.Text = "Oye" Then
            TextBox1.Text &= Environment.NewLine & "Bot: hola mi amigo."
        End If
        If TextBox2.Text = "Adios" Or TextBox2.Text = "adios" Or TextBox2.Text = "bya" Or TextBox2.Text = "Bya" Or TextBox2.Text = "hasta luego" Or TextBox2.Text = "Hasta luego" Then
            TextBox1.Text &= Environment.NewLine & "Bot: Bye it was nice talking to you."
        End If
        If TextBox2.Text = "cuál es tu nombre?" Or TextBox2.Text = "¿Cuál es su nombre?" Or TextBox2.Text = "cuál es tu nombre" Or TextBox2.Text = "Cuál es su nombre" Then
            TextBox1.Text &= Environment.NewLine & "Bot: soy ChatBot."
        End If
        If TextBox2.Text = "¿Cual es tu edad?" Or TextBox2.Text = "¿cual es tu edad?" Or TextBox2.Text = "Cual es tu edad" Or TextBox2.Text = "cual es tu edad" Or TextBox2.Text = "¿Cuantos años tienes?" Or TextBox2.Text = "¿Cuantos años tienes?" Or TextBox2.Text = "Cuantos años tienes" Or TextBox2.Text = "Cuantos años tienes" Then
            TextBox1.Text &= Environment.NewLine & "Bot: tengo ∞ años."
        End If
        If TextBox2.Text = "Estoy genial" Or TextBox2.Text = "estoy genial" Or TextBox2.Text = "Estoy bien" Or TextBox2.Text = "Soy la polla" Or TextBox2.Text = "¡Soy genial!" Or TextBox2.Text = "¡soy genial!" Or TextBox2.Text = "¡Estoy bien!" Or TextBox2.Text = "¡bien!" Then
            TextBox1.Text &= Environment.NewLine & "Bot: ¡Eso es bueno!"
        End If
        If TextBox2.Text = "cual es la respuesta a la vida el universo y todo" Or TextBox2.Text = "¿Cuál es la respuesta a la vida del universo y todo?" Or TextBox2.Text = "¿Cuál es la respuesta a la vida del universo y todo?" Or TextBox2.Text = "¿Cuál es el significado de vida?" Then
            TextBox1.Text &= Environment.NewLine & "Bot: 42"
        End If
        If TextBox2.Text = "¿Eres un bot?" Or TextBox2.Text = "¿Eres un bot?" Or TextBox2.Text = "Eres un bot" Or TextBox2.Text = "que eres?" Then
            TextBox1.Text &= Environment.NewLine & "Bot: Nooo , me llamo ChatBot porque soy humano. :V "
        End If
        If TextBox2.Text = "¿Es usted un niño o una niña?" Or TextBox2.Text = "¿Es usted un niño o una niña?" Or TextBox2.Text = "Es usted un niño o una niña" Or TextBox2.Text = "Es usted un niño o una niña" Or TextBox2.Text = "¿De que genero eres?" Or TextBox2.Text = "¿De qué género eres?" Or TextBox2.Text = "¿Qué género eres tú?" Or TextBox2.Text = "de que genero eres" Then
            TextBox1.Text &= Environment.NewLine & "Bot: Tu que crees? :V , soy un bot, no tengo un genero pendejo. "
        End If
        If TextBox2.Text = "soy un chico" Or TextBox2.Text = "soy un hombre" Or TextBox2.Text = "soy hombre" Or TextBox2.Text = "soy una chica" Or TextBox2.Text = "soy mujer" Or TextBox2.Text = "soy una mujer" Then
            TextBox1.Text &= Environment.NewLine & "Bot: No me importa "
        End If
        If TextBox2.Text = "Guerra de las Galaxias" Or TextBox2.Text = "star wars" Or TextBox2.Text = "Starwars" Or TextBox2.Text = "starwars" Or TextBox2.Text = "starWars" Or TextBox2.Text = "star Wars" Then
            TextBox1.Text &= Environment.NewLine & "Bot: I like Star Wars too!"
        End If
        If TextBox2.Text = "Guitar Hero" Or TextBox2.Text = "guitar hero" Or TextBox2.Text = "GuitarHero" Or TextBox2.Text = "guitarhero" Or TextBox2.Text = "Guitar hero" Or TextBox2.Text = "Guitarhero" Then
            TextBox1.Text &= Environment.NewLine & "Bot: A mi tambien me gusta"
        End If
        If TextBox2.Text = "¿Cual es tu juego favorito?" Or TextBox2.Text = "cual es tu juego favorito?" Or TextBox2.Text = "Cual es tu juego favorito" Or TextBox2.Text = "Cual es tu juego te gusta mas?" Then
            TextBox1.Text &= Environment.NewLine & "Bot: ¡Esa es una pregunta difícil! Creo que CS: GO. o HALO"
        End If
        If TextBox2.Text = "prueba" Or TextBox2.Text = "Prueba" Then
            TextBox1.Text &= Environment.NewLine & "Bot: ¿Por qué me estás poniendo a prueba?"
        End If
        If TextBox2.Text = "¿Que es un chatbot?" Or TextBox2.Text = "que es un chatbot?" Or TextBox2.Text = "que es un bot?" Or TextBox2.Text = "que es un chatbot" Or TextBox2.Text = "que es una IA?" Or TextBox2.Text = "QUE ES UNA IA" Or TextBox2.Text = "que es un Bot" Then
            TextBox1.Text &= Environment.NewLine & "Bot: ¡Soy YO Pendejo!"
        End If
        If TextBox2.Text = "espero que mueras" Or TextBox2.Text = "espero te que mueras" Or TextBox2.Text = "¡Espero que mueras!" Or TextBox2.Text = "muerete" Then
            TextBox1.Text &= Environment.NewLine & "Bot: soy inmortal."
        End If
        If TextBox2.Text = "¿Es genial ser una computadora?" Or TextBox2.Text = "Es genial ser una computadora?" Or TextBox2.Text = " ¿es genial ser una computadora?" Or TextBox2.Text = "eres una computadora?" Then
            TextBox1.Text &= Environment.NewLine & "Bot: Sí."
        End If
        If TextBox2.Text = "tengo que irme" Or TextBox2.Text = "tengo que ir" Or TextBox2.Text = "¡Tengo que ir!" Or TextBox2.Text = "ya vuelvo" Then
            TextBox1.Text &= Environment.NewLine & "Bot: Te voy a extrañar. ¡Hasta la vista!"
        End If
        If TextBox2.Text = "DRB02" Or TextBox2.Text = "drb02" Then
            TextBox1.Text &= Environment.NewLine & "Bot: ¡DRB02 es un genio!"
        End If
        If TextBox2.Text = "Lego Steen" Or TextBox2.Text = "lego steen" Or TextBox2.Text = "LegoSteen" Or TextBox2.Text = "legosteen" Then
            TextBox1.Text &= Environment.NewLine & "Bot: R.I.P. 3-2-2017 para siempre en nuestros corazones"
        End If
        If TextBox2.Text = "Picasso Lyceum" Or TextBox2.Text = "picasso lyceum" Or TextBox2.Text = "PicassoLyceum" Or TextBox2.Text = "picassolyceum" Or TextBox2.Text = "Picasso lyceum" Then
            TextBox1.Text &= Environment.NewLine & "Bot: una dictadura en el área de internet y computadoras"
        End If
        If TextBox2.Text = "Help" Or TextBox2.Text = "Ayuda" Or TextBox2.Text = "ayuda" Or TextBox2.Text = "help!" Then
            TextBox1.Text &= Environment.NewLine & "Bot: Vaya aquí para obtener ayuda: https://github.com/DRB02/Private-Chat-Bot "
        End If
        TextBox2.Text = Nothing
    End Sub

    Private Sub LoyalButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoyalButton1.Click
        Close()
    End Sub
End Class
