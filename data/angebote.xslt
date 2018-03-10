<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="html"/>
  <xsl:template match="offers">
    <xsl:text disable-output-escaping='yes'>&lt;!DOCTYPE html&gt;</xsl:text>
    <html>
      <head>
        <title>Kerstin Sternkopf</title>
        <meta charset="UTF-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <meta name="description" content="Aktuelle Angebote für Tupperware im Landkreis Schwarzenberg. Ihr zuständige Party-Managerin Kerstin Sternkopf." />
        <meta name="keywords" content="Tupperware, Kerstin, Sternkopf" />
        <meta name="language" content="de" />

        <link href="css/w3.css" rel="stylesheet"/>
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>

        <style>

          body {
          margin: 0;
          font-family: Arial, Helvetica, sans-serif;

          }

          #myBtn {
          display: none;
          position: fixed;
          bottom: 20px;
          right: 30px;
          z-index: 99;
          }

          #myBtn:hover {
          background-color: #555;
          }

          /*Um die Linksprünge auf die richtige Position zu setzen*/
          .heading{
          padding-top:40px;
          margin-top:-40px;
          }

          .w3-bar-item {
          text-transform: uppercase;
          }

        </style>
      </head>


      <body>
        <div id="fb-root"></div>
        <script>
          (function(d, s, id) {
          var js, fjs = d.getElementsByTagName(s)[0];
          if (d.getElementById(id)) return;
          js = d.createElement(s); js.id = id;
          js.src = 'https://connect.facebook.net/de_DE/sdk.js#xfbml=1&amp;version=v2.12';
          fjs.parentNode.insertBefore(js, fjs);
          }(document, 'script', 'facebook-jssdk'));
        </script>


        <nav class="w3-top">
          <div class="w3-bar w3-teal w3-wide w3-padding w3-card w3-text-white">
            <a href="#" class="w3-bar-item w3-button w3-hover-pink w3-hide-large w3-hide-medium">
              <strong>K. STERNKOPF</strong>
            </a>
            <a href="#" class="w3-bar-item w3-button w3-hover-pink w3-hide-small">
              <strong>KERSTIN STERNKOPF</strong>
            </a>
            <!-- Float links to the right. Hide them on small screens -->
            <a class="w3-bar-item w3-button w3-hide-large w3-right" href="javascript:void(0);" onclick="toggleNavBar()" title="Navigationsmenü umschalten">
              <i class="fa fa-bars"></i>
            </a>

            <div class="w3-right w3-hide-medium w3-hide-small">
              <a href="#offers" class="w3-button w3-bar-item w3-hover-pink">Angebote</a>
              <a href="#contact" class="w3-button w3-bar-item w3-hover-pink">Kontakt</a>
            </div>
          </div>

          <div id="navDemo" class="w3-bar-block w3-teal w3-hide w3-hide-large w3-text-white">
            <a href="#offers" class="w3-button w3-bar-item" onclick="toggleNavBar()">Angebote</a>
            <a href="#contact" class="w3-button w3-bar-item" onclick="toggleNavBar()">Kontakt</a>
          </div>
        </nav>

        <br></br>
        <br></br>

        <header id="home" class="w3-display-container heading">
          <div class="w3-pink" style="width: 100%; height: 400px"></div>

          <div class="w3-display-middle w3-display-left w3-display-right w3-container w3-center w3-text-white w3-margin-top">
            <img src="img/profil.jpg" class="w3-round w3-margin-top" style="height: 150px" alt="Profilbild"/>
            <h1>KERSTIN STERNKOPF</h1>
            <h4 class="w3-opacity" style="margin-top: 0;">Party Managerin für Tupperware (Beratung &amp; Verkauf) im Erzgebirgskreis</h4>
          </div>
        </header>

        <section id="offers" class="w3-content w3-container w3-center heading" style="max-width: 800px;">
          <h1 class="w3-padding-16 w3-center w3-text-teal" style="padding-bottom: 0px; margin-bottom: 0px;">
            <strong>ANGEBOTE</strong>
          </h1>
          <img src="img/schaber.png" width="300px" style="margin-top: -15px; padding-top: 0px; margin-bottom: 30px;"/>

          <div class="w3-row">
            <xsl:apply-templates/>
          </div>
        </section>

        <div id="contact" class="w3-container w3-content heading w3-center" style="max-width: 500px;">
          <h1 class="w3-padding-16 w3-center w3-text-teal" style="padding-bottom: 0px; margin-bottom: 0px;">
            <strong>KONTAKT</strong>
          </h1>
          <img src="img/schaber.png" width="300px" style="margin-top: -15px; padding-top: 0px; margin-bottom: 30px;"/>

          <p class="w3-left-align">
            Sie wollen meine nächste Gastgeberin sein oder Tupperberaterin werden? Dann kontaktieren Sie mich:
          </p>

          <a class="w3-col s6 w3-button w3-pink" rel="nofollow" title="per WhatsApp Kontakt mit Kerstin aufnehmen" href="https://api.whatsapp.com/send?phone=4917691661003&amp;text=Hallo Kerstin, ich möchte gern Kontakt aufnehmen.">
            <i class="fa fa-whatsapp"></i>
            Kontaktieren
          </a>
          <a class="w3-col s6 w3-button w3-teal" rel="nofollow" title="per Mailprogramm Kontakt mit Kerstin aufnehmen" href="mailto:kerstin_sternkopf@web.de?subject=Kontaktanfrage Tupperware&amp;body=Hallo Kerstin, ich möchte gern Kontakt aufnehmen.">
            <i class="fa fa-envelope"></i>
            Kontaktieren
          </a>
          <!-- geht nicht ohne Mail-Server.
          <form action="contact_me.php" target="_blank" method="post">
            <input class="w3-input" type="text" placeholder="Name" required="" name="name"/>
            <input class="w3-input w3-section" type="text" placeholder="E-Mail" required="" name="email"/>
            <input class="w3-input w3-section" type="text" placeholder="Nachricht" required="" name="message"/>
            <button class="w3-button w3-pink w3-section w3-right" type="submit">
              <i class="fa fa-paper-plane"></i> Nachricht senden
            </button>
          </form>
          -->

        </div>


        <section id="about" class="w3-content w3-container w3-center heading" style="max-width: 400px;">
          <h1 class="w3-padding-16 w3-center w3-text-teal" style="padding-bottom: 0px; margin-bottom: 0px;">
            <strong>ÜBER MICH</strong>
          </h1>
          <img src="img/schaber.png" width="300px" style="margin-top: -15px; padding-top: 0px; margin-bottom: 30px;"/>
          <p class="w3-left-align">Ich arbeite seit mehreren Jahren im Erzgebirgskreis als Party Managerin für Tupperware.</p>
          <br></br>
        </section>


        <section id="about" class="w3-content w3-container w3-center heading" style="max-width: 600px;">
          <h1 class="w3-padding-16 w3-center w3-text-teal" style="padding-bottom: 0px; margin-bottom: 0px;">
            <strong>GÄSTEBUCH</strong>
          </h1>
          <img src="img/schaber.png" width="300px" style="margin-top: -15px; padding-top: 0px; margin-bottom: 30px;"/>

          <p>Vielen Dank für Ihr Feedback!</p>
          <!-- Funktioniert leider nicht mit GitHubPages und keiner eigenen, das
            <p>
            Ich würde mich freuen, wenn Sie meine Seite auf Facebook teilen:
          </p>
          <a href="https://www.facebook.com/sharer/sharer.php?u=https%3A%2F%2Fkerstin-sternkopf.github.io%2F&amp;src=sdkpreparse">
            <button class="w3-button w3-blue w3-margin-bottom">
              <i class="fa fa-facebook"></i> Auf Facebook teilen
            </button>
          </a>
          <div id="disqus_thread"></div>
          -->

          <div id="disqus_thread"></div>
          <script>


            /**
            *  RECOMMENDED CONFIGURATION VARIABLES: EDIT AND UNCOMMENT THE SECTION BELOW TO INSERT DYNAMIC VALUES FROM YOUR PLATFORM OR CMS.
            *  LEARN WHY DEFINING THESE VARIABLES IS IMPORTANT: https://disqus.com/admin/universalcode/#configuration-variables*/

            var disqus_config = function () {
            this.page.url = "https://kerstin-sternkopf.github.io";  // Replace PAGE_URL with your page's canonical URL variable
            this.page.identifier = "https://kerstin-sternkopf.github.io"; // Replace PAGE_IDENTIFIER with your page's unique identifier variable
            };

            (function() { // DON'T EDIT BELOW THIS LINE
            var d = document, s = d.createElement('script');
            s.src = 'https://https-kerstin-sternkopf-github-io.disqus.com/embed.js';
            s.setAttribute('data-timestamp', +new Date());
            (d.head || d.body).appendChild(s);
            })();
          </script>
          <noscript>
            Bitte aktivieren Sie JavaScript um die <a href="https://disqus.com/?ref_noscript">Gästebucheinträge von Disqus anzusehen.</a>
          </noscript>
        </section>
        
        <div id="impressum" class="w3-modal">
          <div class="w3-modal-content w3-animate-bottom">
            <div class="w3-container w3-center">
              <span onclick="document.getElementById('impressum').style.display='none'" class="w3-button w3-pink w3-display-topright">&#215;</span>
              <h1 class="w3-padding-16 w3-center w3-text-teal" style="padding-bottom: 0px; margin-bottom: 0px;">
                <strong>IMPRESSUM</strong>
              </h1>
              <img src="img/schaber.png" width="250px" style="margin-top: -15px; padding-top: 0px; margin-bottom: 30px;"/>

              <div class="w3-left-align">
                <h3>Anbieter</h3>
                Kerstin Sternkopf <br></br>
                Kirchsteig 5 <br></br>
                08340 Schwarzenberg

                <h3>Kontakt</h3>
                Telefon: 0176/91661003 <br></br>
                E-Mail: kerstin_sternkopf@web.de<br></br>

                <h3>Datenschutz allgemein</h3>
                <h4>Disqus-Kommentarsystem</h4>
                <p>
                  Die Disqus-Kommentierungsfunktion wird von der Big Head Labs, Inc., San Francisco, USA als Dienstleistung zur Verfügung gestellt. Disqus ist ein interaktives Kommentarsystem, das es dem Nutzer ermöglicht, mit nur einer Anmeldung auf allen Internetangeboten, die Disqus als Kommentarsystem verwenden, zu kommentieren. Außerdem können sich die Nutzer über bestehende Accounts bei Facebook (über Facebook Connect), Twitter, Yahoo und OpenID anmelden. Auch die Erstellung von Kommentare ohne Registrierung und Anmeldung (als “Gast”) ist möglich. Nähere Informationen zu Disqus und seinen Funktionen finden Sie unter www.disqus.com.
                </p>
                <p>
                  Ihre Daten werden von Disqus verarbeitet und auf Systemen von Disqus gespeichert. Für die Erhebung, Verarbeitung und Nutzung der betreffenden Daten gelten die Nutzungsbedingungen und Datenschutzhinweise von Disqus, zu finden unter <a href="http://docs.disqus.com/help/30/">hier</a> und <a href="http://docs.disqus.com/help/29/">hier</a>. Wenn Sie sich über Ihren Facebook-, Twitter-, Yahoo- oder OpenID-Account anmelden, werden auch von diesen Anbietern möglicherweise Daten erhoben, gespeichert und genutzt. Einzelheiten dazu finden sich in den Datenschutzbestimmungen des jeweiligen Anbieters.
                </p>
                <i>
                  Quelle: <a href="https://www.ambiverse.com/datenschutz/" rel="nofollow">https://www.ambiverse.com/datenschutz/</a>
                </i>

                <h3>Haftungsauschluss</h3>
                <h4>Haftung für Inhalte</h4>
                <p>Als Diensteanbieter sind wir gemäß § 7 Abs.1 TMG für eigene Inhalte auf diesen Seiten nach den allgemeinen Gesetzen verantwortlich. Nach §§ 8 bis 10 TMG sind wir als Diensteanbieter jedoch nicht verpflichtet, übermittelte oder gespeicherte fremde Informationen zu überwachen oder nach Umständen zu forschen, die auf eine rechtswidrige Tätigkeit hinweisen.</p>
                <p>Verpflichtungen zur Entfernung oder Sperrung der Nutzung von Informationen nach den allgemeinen Gesetzen bleiben hiervon unberührt. Eine diesbezügliche Haftung ist jedoch erst ab dem Zeitpunkt der Kenntnis einer konkreten Rechtsverletzung möglich. Bei Bekanntwerden von entsprechenden Rechtsverletzungen werden wir diese Inhalte umgehend entfernen.</p>
                <h4>Haftung für Links</h4>
                <p>Unser Angebot enthält Links zu externen Webseiten Dritter, auf deren Inhalte wir keinen Einfluss haben. Deshalb können wir für diese fremden Inhalte auch keine Gewähr übernehmen. Für die Inhalte der verlinkten Seiten ist stets der jeweilige Anbieter oder Betreiber der Seiten verantwortlich. Die verlinkten Seiten wurden zum Zeitpunkt der Verlinkung auf mögliche Rechtsverstöße überprüft. Rechtswidrige Inhalte waren zum Zeitpunkt der Verlinkung nicht erkennbar.</p>
                <p>Eine permanente inhaltliche Kontrolle der verlinkten Seiten ist jedoch ohne konkrete Anhaltspunkte einer Rechtsverletzung nicht zumutbar. Bei Bekanntwerden von Rechtsverletzungen werden wir derartige Links umgehend entfernen.</p>
                <h4>Urheberrecht</h4>
                <p>Die durch die Seitenbetreiber erstellten Inhalte und Werke auf diesen Seiten unterliegen dem deutschen Urheberrecht. Die Vervielfältigung, Bearbeitung, Verbreitung und jede Art der Verwertung außerhalb der Grenzen des Urheberrechtes bedürfen der schriftlichen Zustimmung des jeweiligen Autors bzw. Erstellers. Downloads und Kopien dieser Seite sind nur für den privaten, nicht kommerziellen Gebrauch gestattet.</p>
                <p>Soweit die Inhalte auf dieser Seite nicht vom Betreiber erstellt wurden, werden die Urheberrechte Dritter beachtet. Insbesondere werden Inhalte Dritter als solche gekennzeichnet. Sollten Sie trotzdem auf eine Urheberrechtsverletzung aufmerksam werden, bitten wir um einen entsprechenden Hinweis. Bei Bekanntwerden von Rechtsverletzungen werden wir derartige Inhalte umgehend entfernen.</p>
                <p>
                  <i>
                    Quelle: <a href="https://www.e-recht24.de" rel="nofollow">https://www.e-recht24.de</a>
                  </i>
                </p>
              </div>
            </div>
          </div>
        </div>

        <footer class="w3-container w3-center w3-teal w3-xlarge w3-padding-64 w3-center">
          <a href="https://www.facebook.com/kerstin.sternkopf.73" target="_blank" rel="nofollow">
            <i class="fa fa-facebook"></i>
          </a>
          <xsl:text> </xsl:text>
          <a href="mailto:kerstin_sternkopf@web.de" rel="nofollow">
            <i class="fa fa-envelope"></i>
          </a>
          <br></br>
          <br></br>
          <p class="w3-medium">
            © 2018 by Kerstin Sternkopf | <a href="javascript:void(0)" onclick="document.getElementById('impressum').style.display='block'">Impressum</a>
          </p>
        </footer>
        
        <button id="myBtn" onclick="topFunction()" class="w3-button w3-small w3-grey w3-opacity" title="Zum Anfang">
          <i class="fa fa-4x fa-angle-up"></i>
        </button>

        <script async="" type="text/javascript">
          // Used to toggle the menu on small screens when clicking on the menu button
          function toggleNavBar() {
          var x = document.getElementById("navDemo");
          if (x.className.indexOf("w3-show") == -1) {
          x.className += " w3-show";
          } else {
          x.className = x.className.replace(" w3-show", "");
          }
          }

          // When the user scrolls down 20px from the top of the document, show the button
          window.onscroll = function() {scrollFunction()};

          function scrollFunction() {
          if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
          document.getElementById("myBtn").style.display = "block";
          } else {
          document.getElementById("myBtn").style.display = "none";
          }
          }

          // When the user clicks on the button, scroll to the top of the document
          function topFunction() {
          document.body.scrollTop = 0;
          document.documentElement.scrollTop = 0;
          }
        </script>
      </body>
    </html>
  </xsl:template>

  <xsl:template match="offer">
    <article class="w3-col w3-margin-bottom w3-card w3-hover-shadow">
      <xsl:variable select="@number" name="nr"/>

      <img class="w3-col m5" alt="{name}" style="padding-right: 8px; max-height: 300px; max-width: 300px;">
        <xsl:attribute name="src">
          <xsl:text>img/</xsl:text>
          <xsl:value-of select="@number"/>
          <xsl:text>.png</xsl:text>
        </xsl:attribute>
        <xsl:attribute name="alt">
          <xsl:value-of select="name"/>
        </xsl:attribute>
      </img>
      <div class="w3-col m7 w3-left-align w3-container">
        <h2 class="w3-border-bottom w3-text-pink">
          <strong>
            <xsl:value-of select="name"/>
            <xsl:if test="parts">
              <xsl:text> (</xsl:text>
              <xsl:value-of select="parts"/>
              <xsl:text>-teilig)</xsl:text>
            </xsl:if>

            <xsl:if test="extras">
              <xsl:text> (</xsl:text>
              <xsl:value-of select="extras"/>
              <xsl:text>)</xsl:text>
            </xsl:if>
          </strong>
        </h2>
        <h3 class="w3-text-red">
          nur <xsl:value-of select="price"/>
          <xsl:if test="saving">
            <div class="w3-medium w3-text-black" style="margin-top: 0;">
              - <xsl:value-of select="saving"/> Ersparnis -
            </div>
          </xsl:if>
        </h3>


        <xsl:if test="volume">
          <p>
            <xsl:text>Inhalt: </xsl:text>
            <xsl:value-of select="volume"/>
          </p>
        </xsl:if>

        <xsl:if test="dimensions">
          <p>
            <xsl:text>Maße: </xsl:text>
            <xsl:value-of select="dimensions"/>
          </p>
        </xsl:if>

        <div class="w3-row" style="width: 100%">
          <a class="w3-col s6 w3-button w3-pink" rel="nofollow" title="per WhatsApp Kontakt mit Kerstin aufnehmen">
            <xsl:attribute name="href">
              <xsl:text>https://api.whatsapp.com/send?phone=4917691661003&amp;text=Hallo ich interessiere mich für: </xsl:text>
              <xsl:value-of select="name"/>
            </xsl:attribute>
            <i class="fa fa-whatsapp"></i>
            Kontaktieren
          </a>
          <a class="w3-col s6 w3-button w3-teal" rel="nofollow" title="per Mailprogramm Kontakt mit Kerstin aufnehmen">
            <xsl:attribute name="href">
              <xsl:text>mailto:kerstin_sternkopf@web.de?subject=Interesse für </xsl:text>
              <xsl:value-of select="name"/>
              <xsl:text>&amp;body=Hallo Kerstin, ich interessiere mich für: </xsl:text>
              <xsl:value-of select="name"/>
              <xsl:text>.</xsl:text>
            </xsl:attribute>
            <i class="fa fa-envelope"></i>
            Kontaktieren
          </a>
        </div>
        <p class="w3-small">
          <xsl:text>Gültig vom </xsl:text>
          <xsl:value-of select="starts"/>
          <xsl:text> bis </xsl:text>
          <xsl:value-of select="ends"/>
        </p>
      </div>
    </article>
  </xsl:template>
</xsl:stylesheet>