﻿function modal(id) {

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
                // Modal Header
                let strContenuModal = "<div class='modal-header'>"
                strContenuModal += " <h4 class='modal-title'>Détails du produit " + prd.nom + "</h4>"
                    // strContenuModal += "<button type='button' class='close' data-dismiss='modal'>&times;</button>" /
                        strContenuModal += "</div>"
                // Modal body
                strContenuModal += "<div class='modal-body d-flex flex-column text-center justify-content-center'>"
                strContenuModal += " <img src=" + prd.srcImage + "class='h-100 w-100'>"
               // strContenuModal += " <h5>" + prd.nom +"</h5>"
                if (prd.quantite >= 1)
    {
                    strContenuModal += "<p style='color:#35B736'> Quantité disponible : " + prd.quantite + "</p>"
    }
                else
    {
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
                // Modal footer 
                strContenuModal += "<div class='modal-footer'>"
                strContenuModal += "<button type='button' class='btn btn-danger' onclick=closeModalProduit() data-dismiss='modal'>Close</button>"
                strContenuModal += "</div>"

                $('.modal-content').html(strContenuModal);
            }
        }
    });
};

function closeModalProduit() {
    $('#myModal').modal('hide');
}