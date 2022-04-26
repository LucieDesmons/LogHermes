function modal(id) {

    /*appel ajax sur le produit, renvoie dans le retour Json (succes : si true fonctionne sinon false --> si true je continue)
     la variable prd contient produit.model, je stock les données dedans
     J'affiche ma modal puis je viens compléter la body du modal avec du contenu dynamique :) */

    $.ajax({
        url: "../GestionStockAPI/getOneProduit",
        data: { id: id },
        type: "POST",
        dataType: "json",
        success: function (data) {
            if (data.success) {
                let prd = data.data[0];
                $('#myModal').modal('toggle');

                //Contenu du modal
                // Modal Header
                let strContenuModal = "<div class='modal-header'>"
                strContenuModal += " <h4 class='modal-title'>Détail du produit " + prd.nom + "</h4>"
                    // strContenuModal += "<button type='button' class='close' data-dismiss='modal'>&times;</button>" /
                        strContenuModal += "</div>"
                // Modal body
                strContenuModal += "<div class='modal-body'>"
                strContenuModal += "Modal body.. teuh mets euh'c'que té veux eud'din tototitiahahahahhhhh"
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