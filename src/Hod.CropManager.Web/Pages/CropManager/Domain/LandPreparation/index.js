$(function () {

    var l = abp.localization.getResource('CropManager');

    var service = cropManager.domain.landPreparation;
    var createModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/LandPreparation/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/LandPreparation/EditModal');

    var dataTable = $('#LandPreparationTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                    return l('LandPreparationDeletionConfirmationMessage', data.record.id);
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
                title: l('LandPreparationField'),
                data: "field"
            },
            {
                title: l('LandPreparationFieldId'),
                data: "fieldId"
            },
            {
                title: l('LandPreparationStartDate'),
                data: "startDate"
            },
            {
                title: l('LandPreparationEndDate'),
                data: "endDate"
            },
            {
                title: l('LandPreparationEquipment'),
                data: "equipment"
            },
            {
                title: l('LandPreparationEquipmentId'),
                data: "equipmentId"
            },
            {
                title: l('LandPreparationSoilTreatment'),
                data: "soilTreatment"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewLandPreparationButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
