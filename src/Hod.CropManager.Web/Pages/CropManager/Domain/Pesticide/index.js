$(function () {

    var l = abp.localization.getResource('CropManager');

    var service = cropManager.domain.pesticide;
    var createModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/Pesticide/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/Pesticide/EditModal');

    var dataTable = $('#PesticideTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                confirmMessage: function (data) {
                                    return l('PesticideDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                    service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            {
                title: l('PesticideName'),
                data: "name"
            },
            {
                title: l('PesticideType'),
                data: "type"
            },
            {
                title: l('PesticideManufacturer'),
                data: "manufacturer"
            },
            {
                title: l('PesticideActiveIngredient'),
                data: "activeIngredient"
            },
            {
                title: l('PesticideFormulation'),
                data: "formulation"
            },
            {
                title: l('PesticideApplicationMethod'),
                data: "applicationMethod"
            },
            {
                title: l('PesticideApplicationRate'),
                data: "applicationRate"
            },
            {
                title: l('PesticidePHI'),
                data: "pHI"
            },
            {
                title: l('PesticideREI'),
                data: "rEI"
            },
            {
                title: l('PesticideSignalWord'),
                data: "signalWord"
            },
            {
                title: l('PesticidePPE'),
                data: "pPE"
            },
            {
                title: l('PesticideNotes'),
                data: "notes"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewPesticideButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
