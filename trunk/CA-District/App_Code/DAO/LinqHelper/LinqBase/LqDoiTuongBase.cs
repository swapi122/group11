




/*
'===============================================================================
'  LinqHelper.DAO.DoiTuongBase
'===============================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using LinqHelper;
using LinqHelper.Entity;
using LinqHelper.DAO;

namespace LinqHelper.DAO
{
	public class LqDoiTuongBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqDoiTuongBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqDoiTuongEntity obj)
		{
			provider.GetTable<LqDoiTuongEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqDoiTuongEntity _obj)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqDoiTuongEntity tmp = q.First<LqDoiTuongEntity>();
			
			tmp.HoTen = _obj.HoTen;
			tmp.HoTenThuongDung = _obj.HoTenThuongDung;
			tmp.BiDanh = _obj.BiDanh;
			tmp.MaRutGon = _obj.MaRutGon;
			tmp.IdGioiTinh = _obj.IdGioiTinh;
			tmp.SinhNgay = _obj.SinhNgay;
			tmp.ChetNgay = _obj.ChetNgay;
			tmp.NoiSinh = _obj.NoiSinh;
			tmp.QueQuan = _obj.QueQuan;
			tmp.NoiO = _obj.NoiO;
			tmp.NoiCuNgu = _obj.NoiCuNgu;
			tmp.IdQuocTich = _obj.IdQuocTich;
			tmp.Cmnd = _obj.Cmnd;
			tmp.NgayCap = _obj.NgayCap;
			tmp.NơiCap = _obj.NơiCap;
			tmp.IdDanToc = _obj.IdDanToc;
			tmp.IdTonGiao = _obj.IdTonGiao;
			tmp.IdChucSac = _obj.IdChucSac;
			tmp.IdTrinhDoHocVan = _obj.IdTrinhDoHocVan;
			tmp.IdNgheNghiep = _obj.IdNgheNghiep;
			tmp.HoTenCha = _obj.HoTenCha;
			tmp.HoTenMe = _obj.HoTenMe;
			tmp.HoTenVoChong = _obj.HoTenVoChong;
			tmp.DacDiemDoiTuong = _obj.DacDiemDoiTuong;
			tmp.IdTinhTrangChinhTri = _obj.IdTinhTrangChinhTri;
			tmp.TienAn = _obj.TienAn;
			tmp.NghienMaTuy = _obj.NghienMaTuy;
			tmp.IdLoaiDoiTuong = _obj.IdLoaiDoiTuong;
			tmp.IdVaiTroTrongVuAn = _obj.IdVaiTroTrongVuAn;
			tmp.IdHanhViPhamToi = _obj.IdHanhViPhamToi;
			tmp.IdQuyDinhHinhSu = _obj.IdQuyDinhHinhSu;
			tmp.IdTinhTrangTheTrang = _obj.IdTinhTrangTheTrang;
			tmp.IdXuLyDoiTuong = _obj.IdXuLyDoiTuong;
			tmp.IdTruongHopBat = _obj.IdTruongHopBat;
			tmp.IdTinhTrangBat = _obj.IdTinhTrangBat;
			tmp.NgayBat = _obj.NgayBat;
			tmp.ThongTinKhac = _obj.ThongTinKhac;
			tmp.TienSu = _obj.TienSu;
			tmp.SoHoSo = _obj.SoHoSo;
			tmp.Hktt = _obj.Hktt;
			tmp.TamTru = _obj.TamTru;
			tmp.NoiLamViec = _obj.NoiLamViec;
			tmp.ChucVu = _obj.ChucVu;
			tmp.SoDienThoai = _obj.SoDienThoai;
			tmp.Fax = _obj.Fax;
			tmp.Email = _obj.Email;
			tmp.Passport = _obj.Passport;
			tmp.QuanHeCanChuY = _obj.QuanHeCanChuY;
			tmp.HinhAnh = _obj.HinhAnh;
			tmp.HoSoThanNhan = _obj.HoSoThanNhan;
			tmp.TrangThaiBat = _obj.TrangThaiBat;
			tmp.IdDonViBat = _obj.IdDonViBat;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqDoiTuongEntity obj)
		{
			provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByHoTen(string HoTen)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.HoTen == HoTen
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByHoTenThuongDung(string HoTenThuongDung)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.HoTenThuongDung == HoTenThuongDung
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByBiDanh(string BiDanh)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.BiDanh == BiDanh
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdGioiTinh(Guid IdGioiTinh)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.IdGioiTinh == IdGioiTinh
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySinhNgay(DateTime SinhNgay)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.SinhNgay.Value == SinhNgay
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByChetNgay(DateTime ChetNgay)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.ChetNgay.Value == ChetNgay
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNoiSinh(string NoiSinh)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.NoiSinh == NoiSinh
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByQueQuan(string QueQuan)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.QueQuan == QueQuan
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNoiO(string NoiO)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.NoiO == NoiO
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNoiCuNgu(string NoiCuNgu)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.NoiCuNgu == NoiCuNgu
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdQuocTich(Guid IdQuocTich)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.IdQuocTich.Value == IdQuocTich
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByCmnd(string Cmnd)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.Cmnd == Cmnd
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCap(DateTime NgayCap)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.NgayCap.Value == NgayCap
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNơiCap(string NơiCap)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.NơiCap == NơiCap
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdDanToc(Guid IdDanToc)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.IdDanToc.Value == IdDanToc
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdTonGiao(Guid IdTonGiao)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.IdTonGiao.Value == IdTonGiao
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdChucSac(Guid IdChucSac)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.IdChucSac.Value == IdChucSac
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdTrinhDoHocVan(Guid IdTrinhDoHocVan)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.IdTrinhDoHocVan.Value == IdTrinhDoHocVan
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNgheNghiep(Guid IdNgheNghiep)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.IdNgheNghiep.Value == IdNgheNghiep
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByHoTenCha(string HoTenCha)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.HoTenCha == HoTenCha
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByHoTenMe(string HoTenMe)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.HoTenMe == HoTenMe
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByHoTenVoChong(string HoTenVoChong)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.HoTenVoChong == HoTenVoChong
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByDacDiemDoiTuong(string DacDiemDoiTuong)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.DacDiemDoiTuong == DacDiemDoiTuong
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdTinhTrangChinhTri(Guid IdTinhTrangChinhTri)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.IdTinhTrangChinhTri.Value == IdTinhTrangChinhTri
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTienAn(string TienAn)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.TienAn == TienAn
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNghienMaTuy(string NghienMaTuy)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.NghienMaTuy == NghienMaTuy
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdLoaiDoiTuong(Guid IdLoaiDoiTuong)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.IdLoaiDoiTuong.Value == IdLoaiDoiTuong
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdVaiTroTrongVuAn(Guid IdVaiTroTrongVuAn)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.IdVaiTroTrongVuAn.Value == IdVaiTroTrongVuAn
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdHanhViPhamToi(Guid IdHanhViPhamToi)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.IdHanhViPhamToi.Value == IdHanhViPhamToi
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdQuyDinhHinhSu(Guid IdQuyDinhHinhSu)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.IdQuyDinhHinhSu.Value == IdQuyDinhHinhSu
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdTinhTrangTheTrang(Guid IdTinhTrangTheTrang)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.IdTinhTrangTheTrang.Value == IdTinhTrangTheTrang
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdXuLyDoiTuong(Guid IdXuLyDoiTuong)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.IdXuLyDoiTuong.Value == IdXuLyDoiTuong
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdTruongHopBat(Guid IdTruongHopBat)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.IdTruongHopBat.Value == IdTruongHopBat
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdTinhTrangBat(Guid IdTinhTrangBat)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.IdTinhTrangBat.Value == IdTinhTrangBat
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayBat(DateTime NgayBat)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.NgayBat.Value == NgayBat
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByThongTinKhac(string ThongTinKhac)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.ThongTinKhac == ThongTinKhac
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTienSu(string TienSu)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.TienSu == TienSu
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySoHoSo(string SoHoSo)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.SoHoSo == SoHoSo
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByHktt(string Hktt)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.Hktt == Hktt
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTamTru(string TamTru)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.TamTru == TamTru
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNoiLamViec(string NoiLamViec)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.NoiLamViec == NoiLamViec
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByChucVu(string ChucVu)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.ChucVu == ChucVu
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySoDienThoai(string SoDienThoai)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.SoDienThoai == SoDienThoai
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByFax(string Fax)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.Fax == Fax
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByEmail(string Email)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.Email == Email
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByPassport(string Passport)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.Passport == Passport
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByQuanHeCanChuY(string QuanHeCanChuY)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.QuanHeCanChuY == QuanHeCanChuY
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByHinhAnh(string HinhAnh)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.HinhAnh == HinhAnh
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByHoSoThanNhan(string HoSoThanNhan)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.HoSoThanNhan == HoSoThanNhan
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThaiBat(string TrangThaiBat)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.TrangThaiBat == TrangThaiBat
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdDonViBat(Guid IdDonViBat)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.IdDonViBat.Value == IdDonViBat
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqDoiTuongEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqDoiTuongEntity ob = (LqDoiTuongEntity)q.First<LqDoiTuongEntity>();
            provider.GetTable<LqDoiTuongEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqDoiTuongEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqDoiTuongEntity>();
		}

		public List<LqDoiTuongEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByHoTen(string HoTen)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.HoTen == HoTen
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByHoTenThuongDung(string HoTenThuongDung)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.HoTenThuongDung == HoTenThuongDung
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByBiDanh(string BiDanh)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.BiDanh == BiDanh
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByIdGioiTinh(Guid IdGioiTinh)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.IdGioiTinh == IdGioiTinh
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectBySinhNgay(DateTime SinhNgay)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.SinhNgay.Value == SinhNgay
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByChetNgay(DateTime ChetNgay)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.ChetNgay.Value == ChetNgay
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByNoiSinh(string NoiSinh)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.NoiSinh == NoiSinh
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByQueQuan(string QueQuan)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.QueQuan == QueQuan
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByNoiO(string NoiO)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.NoiO == NoiO
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByNoiCuNgu(string NoiCuNgu)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.NoiCuNgu == NoiCuNgu
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByIdQuocTich(Guid IdQuocTich)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.IdQuocTich.Value == IdQuocTich
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByCmnd(string Cmnd)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.Cmnd == Cmnd
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByNgayCap(DateTime NgayCap)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.NgayCap.Value == NgayCap
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByNơiCap(string NơiCap)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.NơiCap == NơiCap
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByIdDanToc(Guid IdDanToc)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.IdDanToc.Value == IdDanToc
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByIdTonGiao(Guid IdTonGiao)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.IdTonGiao.Value == IdTonGiao
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByIdChucSac(Guid IdChucSac)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.IdChucSac.Value == IdChucSac
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByIdTrinhDoHocVan(Guid IdTrinhDoHocVan)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.IdTrinhDoHocVan.Value == IdTrinhDoHocVan
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByIdNgheNghiep(Guid IdNgheNghiep)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.IdNgheNghiep.Value == IdNgheNghiep
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByHoTenCha(string HoTenCha)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.HoTenCha == HoTenCha
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByHoTenMe(string HoTenMe)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.HoTenMe == HoTenMe
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByHoTenVoChong(string HoTenVoChong)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.HoTenVoChong == HoTenVoChong
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByDacDiemDoiTuong(string DacDiemDoiTuong)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.DacDiemDoiTuong == DacDiemDoiTuong
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByIdTinhTrangChinhTri(Guid IdTinhTrangChinhTri)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.IdTinhTrangChinhTri.Value == IdTinhTrangChinhTri
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByTienAn(string TienAn)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.TienAn == TienAn
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByNghienMaTuy(string NghienMaTuy)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.NghienMaTuy == NghienMaTuy
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByIdLoaiDoiTuong(Guid IdLoaiDoiTuong)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.IdLoaiDoiTuong.Value == IdLoaiDoiTuong
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByIdVaiTroTrongVuAn(Guid IdVaiTroTrongVuAn)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.IdVaiTroTrongVuAn.Value == IdVaiTroTrongVuAn
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByIdHanhViPhamToi(Guid IdHanhViPhamToi)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.IdHanhViPhamToi.Value == IdHanhViPhamToi
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByIdQuyDinhHinhSu(Guid IdQuyDinhHinhSu)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.IdQuyDinhHinhSu.Value == IdQuyDinhHinhSu
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByIdTinhTrangTheTrang(Guid IdTinhTrangTheTrang)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.IdTinhTrangTheTrang.Value == IdTinhTrangTheTrang
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByIdXuLyDoiTuong(Guid IdXuLyDoiTuong)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.IdXuLyDoiTuong.Value == IdXuLyDoiTuong
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByIdTruongHopBat(Guid IdTruongHopBat)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.IdTruongHopBat.Value == IdTruongHopBat
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByIdTinhTrangBat(Guid IdTinhTrangBat)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.IdTinhTrangBat.Value == IdTinhTrangBat
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByNgayBat(DateTime NgayBat)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.NgayBat.Value == NgayBat
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByThongTinKhac(string ThongTinKhac)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.ThongTinKhac == ThongTinKhac
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByTienSu(string TienSu)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.TienSu == TienSu
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectBySoHoSo(string SoHoSo)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.SoHoSo == SoHoSo
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByHktt(string Hktt)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.Hktt == Hktt
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByTamTru(string TamTru)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.TamTru == TamTru
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByNoiLamViec(string NoiLamViec)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.NoiLamViec == NoiLamViec
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByChucVu(string ChucVu)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.ChucVu == ChucVu
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectBySoDienThoai(string SoDienThoai)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.SoDienThoai == SoDienThoai
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByFax(string Fax)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.Fax == Fax
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByEmail(string Email)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.Email == Email
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByPassport(string Passport)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.Passport == Passport
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByQuanHeCanChuY(string QuanHeCanChuY)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.QuanHeCanChuY == QuanHeCanChuY
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByHinhAnh(string HinhAnh)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.HinhAnh == HinhAnh
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByHoSoThanNhan(string HoSoThanNhan)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.HoSoThanNhan == HoSoThanNhan
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByTrangThaiBat(string TrangThaiBat)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.TrangThaiBat == TrangThaiBat
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByIdDonViBat(Guid IdDonViBat)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.IdDonViBat.Value == IdDonViBat
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		public List<LqDoiTuongEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqDoiTuongEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqDoiTuongEntity>();
		}
		
		
		

	}
}
