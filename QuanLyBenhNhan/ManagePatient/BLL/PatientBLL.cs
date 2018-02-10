using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class PatientBLL
    {
        ManagePatientDataContext db;
        public PatientBLL()
        {
            db = new ManagePatientDataContext();
        }

        public IEnumerable<PatientInfo> GetAllPatient()
        {
            IEnumerable<PatientInfo> data = db.PatientInfos;
            return data;
        }

        public void Add1Patient(PatientInfo patient)
        {
            db.PatientInfos.InsertOnSubmit(patient);
            db.SubmitChanges();
        }

        public void Del1Patient(string id)
        {
            PatientInfo delpatient = (from pt in db.PatientInfos
                                      where pt.IDPatient == id
                                      select pt).FirstOrDefault();
            db.PatientInfos.DeleteOnSubmit(delpatient);
            db.SubmitChanges();
        }

        public void ChangeInfoPatient(PatientInfo patient)
        {
            PatientInfo changepatient = (from pt in db.PatientInfos
                                      where pt.IDPatient == patient.IDPatient
                                      select pt).FirstOrDefault();
            changepatient.IDPatient = patient.IDPatient;
            changepatient.NamePatient = patient.NamePatient;
            changepatient.Address = patient.Address;
            changepatient.Phone = patient.Phone;
            changepatient.Email = patient.Email;
            changepatient.Diagnoseill = patient.Diagnoseill;
            changepatient.IDRoom = patient.IDRoom;
            changepatient.Sex = patient.Sex;
            changepatient.DateOfBirth = patient.DateOfBirth;
            db.SubmitChanges();
        }

        public IEnumerable<PatientInfo> GetPatientById( string id ) // id: id room
        {
            IEnumerable<PatientInfo> data = db.PatientInfos.Where(x => x.IDRoom == id);
            return data;
        }
    }
}
