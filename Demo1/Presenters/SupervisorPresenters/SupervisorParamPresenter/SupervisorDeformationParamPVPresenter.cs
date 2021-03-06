using ProductVertificationDesktopApp.IView;
using ProductVertificationDesktopApp.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductVertificationDesktopApp.Presenters.SupervisorPresenters.SupervisorParamPresenter
{
    class SupervisorDeformationParamPVPresenter
    {
        IViewParametersSetAndSup _viewParametersSetAndSup;
        Is71200ModellingMachine _is71200ModellingMachine;

        public SupervisorDeformationParamPVPresenter(IViewParametersSetAndSup viewParametersSetAndSup, Is71200ModellingMachine is71200ModellingMachine)
        {
            _viewParametersSetAndSup = viewParametersSetAndSup;
            _is71200ModellingMachine = is71200ModellingMachine;
            _is71200ModellingMachine.UpdateData.Add(UpdateView);
        }
        private void UpdateView(bool status)
        {
            _viewParametersSetAndSup.CompressionForceSettingsystem1 = _is71200ModellingMachine.CompressionForceSettingsystem1_PV;
            _viewParametersSetAndSup.CompressionForceSettingsystem2 = _is71200ModellingMachine.CompressionForceSettingsystem2_PV;
            _viewParametersSetAndSup.CompressionForceSettingsystem3 = _is71200ModellingMachine.CompressionForceSettingsystem3_PV;
            _viewParametersSetAndSup.NumberClick1 = _is71200ModellingMachine.NumberClick1_PV;
            _viewParametersSetAndSup.NumberClick2 = _is71200ModellingMachine.NumberClick2_PV;
            _viewParametersSetAndSup.NumberClick3 = _is71200ModellingMachine.NumberClick3_PV;

        }
    }
}
