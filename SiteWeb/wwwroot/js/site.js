function modal(id) {

    /*appel ajax sur le produit, renvoie dans le retour Json (succes : si true fonctionne sinon false --> si true je continue)
     la variable prd contient produit.model, je stock les données dedans
     J'affiche ma modal puis je viens compléter le body de la modal avec du contenu dynamique :) */

    $.ajax({
        url: "../GestionStockAPI/getOneProduit",
        data: { id: id },
        type: "POST",
        dataType: "json",
        success: function (data) {
            if (data.success) {
                let prd = data.data[0];
                $('#myModal').modal('toggle');

                //Contenu modal
                    // strContenuModal += "<button type='button' class='close' data-dismiss='modal'>&times;</button>" /
                // Modal body
                
                let strContenuModal = "<div class='modal-body d-flex flex-column text-center justify-content-center'>"
                    strContenuModal += "<div class='row'>"

                        strContenuModal += "<div class='col-6 d-flex flex-column justify-content-between border-right'>"
                        strContenuModal += " <h4>Détails du produit " + prd.nom + "</h4>"
                            /*strContenuModal += " <img src=" + prd.Image + "class='h-100 w-100'>"*/
                            if (prd.quantite >= 1) {
                                strContenuModal += "<p style='color:#35B736'> Quantité disponible : " + prd.quantite + "</p>"
                            }
                            else {
                                strContenuModal += "<p style='color:#E2202C'> Quantité disponible : " + prd.quantite + "</p>"
                            }
                            strContenuModal += "<p> Catégorie : " + prd.categorie.nom + "</p>"
                            strContenuModal += "<p> Maison : " + prd.maison + "</p>"
                            strContenuModal += "<p> Année : " + prd.annee + "</p>"
                            strContenuModal += "<p>" + prd.description + "</p>"

                            strContenuModal += "<div class='row'>"
                                strContenuModal += "<div class='col-6'>"
                                    strContenuModal += "<p>" + prd.prix + "€ / unité" + "</p>"
                                strContenuModal += "</div>"
                                strContenuModal += "<div class='col-6'>"
                                    strContenuModal += "<p>" + prd.prixcarton + "€ / carton" + "</p>"
                                strContenuModal += "</div>"
                            strContenuModal += "</div>"

                        strContenuModal += "</div>"

                        strContenuModal += "<div class='col-6 d-flex flex-column justify-content-between'>"
                            strContenuModal += "<h4> Je souhaite commander... </h5>"
                            strContenuModal += "<p class='m-0 p-2'> Attention: Si vous prenez l'option 'Carton de vins' la quantité sera basée dessus. </p>"

                        strContenuModal += "<div class='row d-flex p-2'>"
                            strContenuModal += "<div class='col-4 d-flex justify-content-center align-items-center'>"
                                strContenuModal += "<label style='color:#f5585c; font-weight:bold;'> Carton de vins : </label>"
                            strContenuModal += "</div>"
                            strContenuModal += "<div class='col-8'>"
                                strContenuModal += "<div class='form-check' >"
                                    strContenuModal += "<input class='form-check-input' type='radio' name='flexRadioDefault' id='flexRadioDefault1'>"
                                    strContenuModal += "<label class='form-check-label d-flex justify-content-start' for='flexRadioDefault1'>"
                                    strContenuModal += "Oui"
                                    strContenuModal += "</label>"
                                strContenuModal += "</div>"
                                strContenuModal += "<div class='form-check' >"
                                    strContenuModal += "<input class='form-check-input' type='radio' name='flexRadioDefault' id='flexRadioDefault2'>"
                                    strContenuModal += "<label class='form-check-label d-flex justify-content-start' for='flexRadioDefault2'>"
                                    strContenuModal += "Non"
                                    strContenuModal += "</label>"
                                strContenuModal += "</div>"
                            strContenuModal += "</div>"
                        strContenuModal += "</div>"

                            strContenuModal += "<div class='row d-flex p-2'>"
                                strContenuModal += "<div class='col-4 d-flex justify-content-center align-items-center'>"
                                    strContenuModal += "<label> Quantité : </label>"
                                strContenuModal += "</div>"
                                strContenuModal += "<div class='col-8'>"
                                    strContenuModal += "<input type ='number' id ='quantiteCmd' class='form-control active' value ='1' >"
                                strContenuModal += "</div>"   
                            strContenuModal += "</div>"   

                            strContenuModal += "<div class='row d-flex p-2'>"
                                strContenuModal += "<div class='col-4 d-flex justify-content-center align-items-center'>"
                                    strContenuModal += "<label>  Prix HT : </label>"
                                strContenuModal += "</div>"
                                strContenuModal += "<div class='col-8'>"
                                    strContenuModal += "<input id ='PrixCmd' class='form-control active' value ='1' >"
                                strContenuModal += "</div>"
                            strContenuModal += "</div>"    

                            strContenuModal += "<div class='row p-2 mt-4'>"
                                strContenuModal += "<button type ='button' class='btn btn-primary' data-target='#exampleModalCenter'>Ajouter au panier</button>"
                            strContenuModal += "</div>"

                        strContenuModal += "</div>"

                    strContenuModal += "</div>"
               strContenuModal += "</div>"
                        
                
                // Modal footer 
                strContenuModal += "<div class='modal-footer'>"
                strContenuModal += "<button type='button' class='btn btn-danger' onclick=closeModalProduit() data-dismiss='modal'>Annuler</button>"
                strContenuModal += "</div>"

                $('.modal-content').html(strContenuModal);
            }
        }
    });
};

function closeModalProduit() {
    $('#myModal').modal('hide');
}