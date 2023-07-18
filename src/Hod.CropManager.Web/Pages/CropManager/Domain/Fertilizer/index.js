$(function () {

    var l = abp.localization.getResource('CropManager');

    var service = cropManager.domain.fertilizer;
    var createModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/Fertilizer/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/Fertilizer/EditModal');

    var dataTable = $('#FertilizerTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                    return l('FertilizerDeletionConfirmationMessage', data.record.id);
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
                title: l('FertilizerName'),
                data: "name"
            },
            {
                title: l('FertilizerType'),
                data: "type"
            },
            {
                title: l('FertilizerManufacturer'),
                data: "manufacturer"
            },
            {
                title: l('FertilizerNPK'),
                data: "nPK"
            },
            {
                title: l('FertilizerApplicationMethod'),
                data: "applicationMethod"
            },
            {
                title: l('FertilizerApplicationRate'),
                data: "applicationRate"
            },
            {
                title: l('FertilizerNotes'),
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

    $('#NewFertilizerButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
