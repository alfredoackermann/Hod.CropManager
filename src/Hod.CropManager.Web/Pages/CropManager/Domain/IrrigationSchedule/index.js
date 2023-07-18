$(function () {

    var l = abp.localization.getResource('CropManager');

    var service = cropManager.domain.irrigationSchedule;
    var createModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/IrrigationSchedule/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/IrrigationSchedule/EditModal');

    var dataTable = $('#IrrigationScheduleTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                    return l('IrrigationScheduleDeletionConfirmationMessage', data.record.id);
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
                title: l('IrrigationScheduleCrop'),
                data: "crop"
            },
            {
                title: l('IrrigationScheduleCropId'),
                data: "cropId"
            },
            {
                title: l('IrrigationScheduleStartDate'),
                data: "startDate"
            },
            {
                title: l('IrrigationScheduleEndDate'),
                data: "endDate"
            },
            {
                title: l('IrrigationScheduleVolume'),
                data: "volume"
            },
            {
                title: l('IrrigationScheduleIrrigationSystem'),
                data: "irrigationSystem"
            },
            {
                title: l('IrrigationScheduleIrrigationSystemId'),
                data: "irrigationSystemId"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewIrrigationScheduleButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
