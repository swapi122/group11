




/*
'===============================================================================
'  LayerHelper.CAQ.BL.DoiTuongManagerBase
'===============================================================================
*/

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using LayerHelper.CAQ.BLL;
using LayerHelper.CAQ.DAL;
using LayerHelper.CAQ.DAL.EntityClasses;
using LayerHelper.CAQ.DAL.FactoryClasses;
using LayerHelper.CAQ.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LayerHelper.CAQ.BLL
{
	public class DoiTuongManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DoiTuongManagerBase()
		{
			// Nothing for now.
		}
		
		public DoiTuongEntity Insert(DoiTuongEntity _DoiTuongEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_DoiTuongEntity, true);
			}
			return _DoiTuongEntity;
		}

		
		public DoiTuongEntity Insert(Guid Id, string HoTen, string HoTenThuongDung, string BiDanh, string MaRutGon, Guid IdGioiTinh, DateTime SinhNgay, DateTime ChetNgay, string NoiSinh, string QueQuan, string NoiO, string NoiCuNgu, Guid IdQuocTich, string Cmnd, DateTime NgayCap, string NơiCap, Guid IdDanToc, Guid IdTonGiao, Guid IdChucSac, Guid IdTrinhDoHocVan, Guid IdNgheNghiep, string HoTenCha, string HoTenMe, string HoTenVoChong, string DacDiemDoiTuong, Guid IdTinhTrangChinhTri, string TienAn, string NghienMaTuy, Guid IdLoaiDoiTuong, Guid IdVaiTroTrongVuAn, Guid IdHanhViPhamToi, Guid IdQuyDinhHinhSu, Guid IdTinhTrangTheTrang, Guid IdXuLyDoiTuong, Guid IdTruongHopBat, Guid IdTinhTrangBat, DateTime NgayBat, string ThongTinKhac, string TienSu, string SoHoSo, string Hktt, string TamTru, string NoiLamViec, string ChucVu, string SoDienThoai, string Fax, string Email, string Passport, string QuanHeCanChuY, string HinhAnh, string HoSoThanNhan, string TrangThaiBat, Guid IdDonViBat, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			DoiTuongEntity _DoiTuongEntity = new DoiTuongEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DoiTuongEntity.Id = Id;
				_DoiTuongEntity.HoTen = HoTen;
				_DoiTuongEntity.HoTenThuongDung = HoTenThuongDung;
				_DoiTuongEntity.BiDanh = BiDanh;
				_DoiTuongEntity.MaRutGon = MaRutGon;
				_DoiTuongEntity.IdGioiTinh = IdGioiTinh;
				_DoiTuongEntity.SinhNgay = SinhNgay;
				_DoiTuongEntity.ChetNgay = ChetNgay;
				_DoiTuongEntity.NoiSinh = NoiSinh;
				_DoiTuongEntity.QueQuan = QueQuan;
				_DoiTuongEntity.NoiO = NoiO;
				_DoiTuongEntity.NoiCuNgu = NoiCuNgu;
				_DoiTuongEntity.IdQuocTich = IdQuocTich;
				_DoiTuongEntity.Cmnd = Cmnd;
				_DoiTuongEntity.NgayCap = NgayCap;
				_DoiTuongEntity.NơiCap = NơiCap;
				_DoiTuongEntity.IdDanToc = IdDanToc;
				_DoiTuongEntity.IdTonGiao = IdTonGiao;
				_DoiTuongEntity.IdChucSac = IdChucSac;
				_DoiTuongEntity.IdTrinhDoHocVan = IdTrinhDoHocVan;
				_DoiTuongEntity.IdNgheNghiep = IdNgheNghiep;
				_DoiTuongEntity.HoTenCha = HoTenCha;
				_DoiTuongEntity.HoTenMe = HoTenMe;
				_DoiTuongEntity.HoTenVoChong = HoTenVoChong;
				_DoiTuongEntity.DacDiemDoiTuong = DacDiemDoiTuong;
				_DoiTuongEntity.IdTinhTrangChinhTri = IdTinhTrangChinhTri;
				_DoiTuongEntity.TienAn = TienAn;
				_DoiTuongEntity.NghienMaTuy = NghienMaTuy;
				_DoiTuongEntity.IdLoaiDoiTuong = IdLoaiDoiTuong;
				_DoiTuongEntity.IdVaiTroTrongVuAn = IdVaiTroTrongVuAn;
				_DoiTuongEntity.IdHanhViPhamToi = IdHanhViPhamToi;
				_DoiTuongEntity.IdQuyDinhHinhSu = IdQuyDinhHinhSu;
				_DoiTuongEntity.IdTinhTrangTheTrang = IdTinhTrangTheTrang;
				_DoiTuongEntity.IdXuLyDoiTuong = IdXuLyDoiTuong;
				_DoiTuongEntity.IdTruongHopBat = IdTruongHopBat;
				_DoiTuongEntity.IdTinhTrangBat = IdTinhTrangBat;
				_DoiTuongEntity.NgayBat = NgayBat;
				_DoiTuongEntity.ThongTinKhac = ThongTinKhac;
				_DoiTuongEntity.TienSu = TienSu;
				_DoiTuongEntity.SoHoSo = SoHoSo;
				_DoiTuongEntity.Hktt = Hktt;
				_DoiTuongEntity.TamTru = TamTru;
				_DoiTuongEntity.NoiLamViec = NoiLamViec;
				_DoiTuongEntity.ChucVu = ChucVu;
				_DoiTuongEntity.SoDienThoai = SoDienThoai;
				_DoiTuongEntity.Fax = Fax;
				_DoiTuongEntity.Email = Email;
				_DoiTuongEntity.Passport = Passport;
				_DoiTuongEntity.QuanHeCanChuY = QuanHeCanChuY;
				_DoiTuongEntity.HinhAnh = HinhAnh;
				_DoiTuongEntity.HoSoThanNhan = HoSoThanNhan;
				_DoiTuongEntity.TrangThaiBat = TrangThaiBat;
				_DoiTuongEntity.IdDonViBat = IdDonViBat;
				_DoiTuongEntity.IdNguoiTao = IdNguoiTao;
				_DoiTuongEntity.NgayTao = NgayTao;
				_DoiTuongEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_DoiTuongEntity.NgayCapNhat = NgayCapNhat;
				_DoiTuongEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_DoiTuongEntity, true);
			}
			return _DoiTuongEntity;
		}

		public DoiTuongEntity Insert(string HoTen, string HoTenThuongDung, string BiDanh, string MaRutGon, Guid IdGioiTinh, DateTime SinhNgay, DateTime ChetNgay, string NoiSinh, string QueQuan, string NoiO, string NoiCuNgu, Guid IdQuocTich, string Cmnd, DateTime NgayCap, string NơiCap, Guid IdDanToc, Guid IdTonGiao, Guid IdChucSac, Guid IdTrinhDoHocVan, Guid IdNgheNghiep, string HoTenCha, string HoTenMe, string HoTenVoChong, string DacDiemDoiTuong, Guid IdTinhTrangChinhTri, string TienAn, string NghienMaTuy, Guid IdLoaiDoiTuong, Guid IdVaiTroTrongVuAn, Guid IdHanhViPhamToi, Guid IdQuyDinhHinhSu, Guid IdTinhTrangTheTrang, Guid IdXuLyDoiTuong, Guid IdTruongHopBat, Guid IdTinhTrangBat, DateTime NgayBat, string ThongTinKhac, string TienSu, string SoHoSo, string Hktt, string TamTru, string NoiLamViec, string ChucVu, string SoDienThoai, string Fax, string Email, string Passport, string QuanHeCanChuY, string HinhAnh, string HoSoThanNhan, string TrangThaiBat, Guid IdDonViBat, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			DoiTuongEntity _DoiTuongEntity = new DoiTuongEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DoiTuongEntity.HoTen = HoTen;
				_DoiTuongEntity.HoTenThuongDung = HoTenThuongDung;
				_DoiTuongEntity.BiDanh = BiDanh;
				_DoiTuongEntity.MaRutGon = MaRutGon;
				_DoiTuongEntity.IdGioiTinh = IdGioiTinh;
				_DoiTuongEntity.SinhNgay = SinhNgay;
				_DoiTuongEntity.ChetNgay = ChetNgay;
				_DoiTuongEntity.NoiSinh = NoiSinh;
				_DoiTuongEntity.QueQuan = QueQuan;
				_DoiTuongEntity.NoiO = NoiO;
				_DoiTuongEntity.NoiCuNgu = NoiCuNgu;
				_DoiTuongEntity.IdQuocTich = IdQuocTich;
				_DoiTuongEntity.Cmnd = Cmnd;
				_DoiTuongEntity.NgayCap = NgayCap;
				_DoiTuongEntity.NơiCap = NơiCap;
				_DoiTuongEntity.IdDanToc = IdDanToc;
				_DoiTuongEntity.IdTonGiao = IdTonGiao;
				_DoiTuongEntity.IdChucSac = IdChucSac;
				_DoiTuongEntity.IdTrinhDoHocVan = IdTrinhDoHocVan;
				_DoiTuongEntity.IdNgheNghiep = IdNgheNghiep;
				_DoiTuongEntity.HoTenCha = HoTenCha;
				_DoiTuongEntity.HoTenMe = HoTenMe;
				_DoiTuongEntity.HoTenVoChong = HoTenVoChong;
				_DoiTuongEntity.DacDiemDoiTuong = DacDiemDoiTuong;
				_DoiTuongEntity.IdTinhTrangChinhTri = IdTinhTrangChinhTri;
				_DoiTuongEntity.TienAn = TienAn;
				_DoiTuongEntity.NghienMaTuy = NghienMaTuy;
				_DoiTuongEntity.IdLoaiDoiTuong = IdLoaiDoiTuong;
				_DoiTuongEntity.IdVaiTroTrongVuAn = IdVaiTroTrongVuAn;
				_DoiTuongEntity.IdHanhViPhamToi = IdHanhViPhamToi;
				_DoiTuongEntity.IdQuyDinhHinhSu = IdQuyDinhHinhSu;
				_DoiTuongEntity.IdTinhTrangTheTrang = IdTinhTrangTheTrang;
				_DoiTuongEntity.IdXuLyDoiTuong = IdXuLyDoiTuong;
				_DoiTuongEntity.IdTruongHopBat = IdTruongHopBat;
				_DoiTuongEntity.IdTinhTrangBat = IdTinhTrangBat;
				_DoiTuongEntity.NgayBat = NgayBat;
				_DoiTuongEntity.ThongTinKhac = ThongTinKhac;
				_DoiTuongEntity.TienSu = TienSu;
				_DoiTuongEntity.SoHoSo = SoHoSo;
				_DoiTuongEntity.Hktt = Hktt;
				_DoiTuongEntity.TamTru = TamTru;
				_DoiTuongEntity.NoiLamViec = NoiLamViec;
				_DoiTuongEntity.ChucVu = ChucVu;
				_DoiTuongEntity.SoDienThoai = SoDienThoai;
				_DoiTuongEntity.Fax = Fax;
				_DoiTuongEntity.Email = Email;
				_DoiTuongEntity.Passport = Passport;
				_DoiTuongEntity.QuanHeCanChuY = QuanHeCanChuY;
				_DoiTuongEntity.HinhAnh = HinhAnh;
				_DoiTuongEntity.HoSoThanNhan = HoSoThanNhan;
				_DoiTuongEntity.TrangThaiBat = TrangThaiBat;
				_DoiTuongEntity.IdDonViBat = IdDonViBat;
				_DoiTuongEntity.IdNguoiTao = IdNguoiTao;
				_DoiTuongEntity.NgayTao = NgayTao;
				_DoiTuongEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_DoiTuongEntity.NgayCapNhat = NgayCapNhat;
				_DoiTuongEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_DoiTuongEntity, true);
			}
			return _DoiTuongEntity;
		}

		public bool Update(DoiTuongEntity _DoiTuongEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(DoiTuongFields.Id == _DoiTuongEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DoiTuongEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DoiTuongEntity _DoiTuongEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DoiTuongEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string HoTen, string HoTenThuongDung, string BiDanh, string MaRutGon, Guid IdGioiTinh, DateTime SinhNgay, DateTime ChetNgay, string NoiSinh, string QueQuan, string NoiO, string NoiCuNgu, Guid IdQuocTich, string Cmnd, DateTime NgayCap, string NơiCap, Guid IdDanToc, Guid IdTonGiao, Guid IdChucSac, Guid IdTrinhDoHocVan, Guid IdNgheNghiep, string HoTenCha, string HoTenMe, string HoTenVoChong, string DacDiemDoiTuong, Guid IdTinhTrangChinhTri, string TienAn, string NghienMaTuy, Guid IdLoaiDoiTuong, Guid IdVaiTroTrongVuAn, Guid IdHanhViPhamToi, Guid IdQuyDinhHinhSu, Guid IdTinhTrangTheTrang, Guid IdXuLyDoiTuong, Guid IdTruongHopBat, Guid IdTinhTrangBat, DateTime NgayBat, string ThongTinKhac, string TienSu, string SoHoSo, string Hktt, string TamTru, string NoiLamViec, string ChucVu, string SoDienThoai, string Fax, string Email, string Passport, string QuanHeCanChuY, string HinhAnh, string HoSoThanNhan, string TrangThaiBat, Guid IdDonViBat, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DoiTuongEntity _DoiTuongEntity = new DoiTuongEntity(Id);
				if (adapter.FetchEntity(_DoiTuongEntity))
				{
				
					_DoiTuongEntity.HoTen = HoTen;
					_DoiTuongEntity.HoTenThuongDung = HoTenThuongDung;
					_DoiTuongEntity.BiDanh = BiDanh;
					_DoiTuongEntity.MaRutGon = MaRutGon;
					_DoiTuongEntity.IdGioiTinh = IdGioiTinh;
					_DoiTuongEntity.SinhNgay = SinhNgay;
					_DoiTuongEntity.ChetNgay = ChetNgay;
					_DoiTuongEntity.NoiSinh = NoiSinh;
					_DoiTuongEntity.QueQuan = QueQuan;
					_DoiTuongEntity.NoiO = NoiO;
					_DoiTuongEntity.NoiCuNgu = NoiCuNgu;
					_DoiTuongEntity.IdQuocTich = IdQuocTich;
					_DoiTuongEntity.Cmnd = Cmnd;
					_DoiTuongEntity.NgayCap = NgayCap;
					_DoiTuongEntity.NơiCap = NơiCap;
					_DoiTuongEntity.IdDanToc = IdDanToc;
					_DoiTuongEntity.IdTonGiao = IdTonGiao;
					_DoiTuongEntity.IdChucSac = IdChucSac;
					_DoiTuongEntity.IdTrinhDoHocVan = IdTrinhDoHocVan;
					_DoiTuongEntity.IdNgheNghiep = IdNgheNghiep;
					_DoiTuongEntity.HoTenCha = HoTenCha;
					_DoiTuongEntity.HoTenMe = HoTenMe;
					_DoiTuongEntity.HoTenVoChong = HoTenVoChong;
					_DoiTuongEntity.DacDiemDoiTuong = DacDiemDoiTuong;
					_DoiTuongEntity.IdTinhTrangChinhTri = IdTinhTrangChinhTri;
					_DoiTuongEntity.TienAn = TienAn;
					_DoiTuongEntity.NghienMaTuy = NghienMaTuy;
					_DoiTuongEntity.IdLoaiDoiTuong = IdLoaiDoiTuong;
					_DoiTuongEntity.IdVaiTroTrongVuAn = IdVaiTroTrongVuAn;
					_DoiTuongEntity.IdHanhViPhamToi = IdHanhViPhamToi;
					_DoiTuongEntity.IdQuyDinhHinhSu = IdQuyDinhHinhSu;
					_DoiTuongEntity.IdTinhTrangTheTrang = IdTinhTrangTheTrang;
					_DoiTuongEntity.IdXuLyDoiTuong = IdXuLyDoiTuong;
					_DoiTuongEntity.IdTruongHopBat = IdTruongHopBat;
					_DoiTuongEntity.IdTinhTrangBat = IdTinhTrangBat;
					_DoiTuongEntity.NgayBat = NgayBat;
					_DoiTuongEntity.ThongTinKhac = ThongTinKhac;
					_DoiTuongEntity.TienSu = TienSu;
					_DoiTuongEntity.SoHoSo = SoHoSo;
					_DoiTuongEntity.Hktt = Hktt;
					_DoiTuongEntity.TamTru = TamTru;
					_DoiTuongEntity.NoiLamViec = NoiLamViec;
					_DoiTuongEntity.ChucVu = ChucVu;
					_DoiTuongEntity.SoDienThoai = SoDienThoai;
					_DoiTuongEntity.Fax = Fax;
					_DoiTuongEntity.Email = Email;
					_DoiTuongEntity.Passport = Passport;
					_DoiTuongEntity.QuanHeCanChuY = QuanHeCanChuY;
					_DoiTuongEntity.HinhAnh = HinhAnh;
					_DoiTuongEntity.HoSoThanNhan = HoSoThanNhan;
					_DoiTuongEntity.TrangThaiBat = TrangThaiBat;
					_DoiTuongEntity.IdDonViBat = IdDonViBat;
					_DoiTuongEntity.IdNguoiTao = IdNguoiTao;
					_DoiTuongEntity.NgayTao = NgayTao;
					_DoiTuongEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_DoiTuongEntity.NgayCapNhat = NgayCapNhat;
					_DoiTuongEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_DoiTuongEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(Guid Id)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DoiTuongEntity _DoiTuongEntity = new DoiTuongEntity(Id);
				if (adapter.FetchEntity(_DoiTuongEntity))
				{
					adapter.DeleteEntity(_DoiTuongEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DoiTuongEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByHoTen(string HoTen)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HoTen == HoTen);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByHoTenThuongDung(string HoTenThuongDung)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HoTenThuongDung == HoTenThuongDung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByBiDanh(string BiDanh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.BiDanh == BiDanh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdGioiTinh(Guid IdGioiTinh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdGioiTinh == IdGioiTinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySinhNgay(DateTime SinhNgay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.SinhNgay == SinhNgay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByChetNgay(DateTime ChetNgay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.ChetNgay == ChetNgay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNoiSinh(string NoiSinh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NoiSinh == NoiSinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByQueQuan(string QueQuan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.QueQuan == QueQuan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNoiO(string NoiO)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NoiO == NoiO);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNoiCuNgu(string NoiCuNgu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NoiCuNgu == NoiCuNgu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdQuocTich(Guid IdQuocTich)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdQuocTich == IdQuocTich);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCmnd(string Cmnd)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.Cmnd == Cmnd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCap(DateTime NgayCap)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NgayCap == NgayCap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNơiCap(string NơiCap)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NơiCap == NơiCap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdDanToc(Guid IdDanToc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdDanToc == IdDanToc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdTonGiao(Guid IdTonGiao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdTonGiao == IdTonGiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdChucSac(Guid IdChucSac)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdChucSac == IdChucSac);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdTrinhDoHocVan(Guid IdTrinhDoHocVan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdTrinhDoHocVan == IdTrinhDoHocVan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNgheNghiep(Guid IdNgheNghiep)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdNgheNghiep == IdNgheNghiep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByHoTenCha(string HoTenCha)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HoTenCha == HoTenCha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByHoTenMe(string HoTenMe)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HoTenMe == HoTenMe);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByHoTenVoChong(string HoTenVoChong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HoTenVoChong == HoTenVoChong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDacDiemDoiTuong(string DacDiemDoiTuong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.DacDiemDoiTuong == DacDiemDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdTinhTrangChinhTri(Guid IdTinhTrangChinhTri)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdTinhTrangChinhTri == IdTinhTrangChinhTri);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTienAn(string TienAn)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.TienAn == TienAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNghienMaTuy(string NghienMaTuy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NghienMaTuy == NghienMaTuy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdLoaiDoiTuong(Guid IdLoaiDoiTuong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdLoaiDoiTuong == IdLoaiDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdVaiTroTrongVuAn(Guid IdVaiTroTrongVuAn)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdVaiTroTrongVuAn == IdVaiTroTrongVuAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdHanhViPhamToi(Guid IdHanhViPhamToi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdHanhViPhamToi == IdHanhViPhamToi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdQuyDinhHinhSu(Guid IdQuyDinhHinhSu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdQuyDinhHinhSu == IdQuyDinhHinhSu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdTinhTrangTheTrang(Guid IdTinhTrangTheTrang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdTinhTrangTheTrang == IdTinhTrangTheTrang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdXuLyDoiTuong(Guid IdXuLyDoiTuong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdXuLyDoiTuong == IdXuLyDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdTruongHopBat(Guid IdTruongHopBat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdTruongHopBat == IdTruongHopBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdTinhTrangBat(Guid IdTinhTrangBat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdTinhTrangBat == IdTinhTrangBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayBat(DateTime NgayBat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NgayBat == NgayBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByThongTinKhac(string ThongTinKhac)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.ThongTinKhac == ThongTinKhac);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTienSu(string TienSu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.TienSu == TienSu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySoHoSo(string SoHoSo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.SoHoSo == SoHoSo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByHktt(string Hktt)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.Hktt == Hktt);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTamTru(string TamTru)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.TamTru == TamTru);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNoiLamViec(string NoiLamViec)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NoiLamViec == NoiLamViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByChucVu(string ChucVu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.ChucVu == ChucVu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySoDienThoai(string SoDienThoai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.SoDienThoai == SoDienThoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByFax(string Fax)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.Fax == Fax);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByEmail(string Email)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPassport(string Passport)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.Passport == Passport);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByQuanHeCanChuY(string QuanHeCanChuY)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.QuanHeCanChuY == QuanHeCanChuY);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByHinhAnh(string HinhAnh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HinhAnh == HinhAnh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByHoSoThanNhan(string HoSoThanNhan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HoSoThanNhan == HoSoThanNhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThaiBat(string TrangThaiBat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.TrangThaiBat == TrangThaiBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdDonViBat(Guid IdDonViBat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdDonViBat == IdDonViBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DoiTuongEntity", filter);
			}
			return toReturn;
		}
		

		
		public DoiTuongEntity SelectOne(Guid Id)
		{
			DoiTuongEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DoiTuongEntity _DoiTuongEntity = new DoiTuongEntity(Id);
				if (adapter.FetchEntity(_DoiTuongEntity))
				{
					toReturn = _DoiTuongEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectAllLST()
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, null, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByHoTenLST(string HoTen)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HoTen == HoTen);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByHoTenLST_Paged(string HoTen, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HoTen == HoTen);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByHoTenRDT(string HoTen)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HoTen == HoTen);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByHoTenRDT_Paged(string HoTen, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HoTen == HoTen);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByHoTenThuongDungLST(string HoTenThuongDung)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HoTenThuongDung == HoTenThuongDung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByHoTenThuongDungLST_Paged(string HoTenThuongDung, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HoTenThuongDung == HoTenThuongDung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByHoTenThuongDungRDT(string HoTenThuongDung)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HoTenThuongDung == HoTenThuongDung);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByHoTenThuongDungRDT_Paged(string HoTenThuongDung, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HoTenThuongDung == HoTenThuongDung);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByBiDanhLST(string BiDanh)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.BiDanh == BiDanh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByBiDanhLST_Paged(string BiDanh, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.BiDanh == BiDanh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByBiDanhRDT(string BiDanh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.BiDanh == BiDanh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByBiDanhRDT_Paged(string BiDanh, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.BiDanh == BiDanh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdGioiTinhLST(Guid IdGioiTinh)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdGioiTinh == IdGioiTinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdGioiTinhLST_Paged(Guid IdGioiTinh, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdGioiTinh == IdGioiTinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdGioiTinhRDT(Guid IdGioiTinh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdGioiTinh == IdGioiTinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdGioiTinhRDT_Paged(Guid IdGioiTinh, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdGioiTinh == IdGioiTinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectBySinhNgayLST(DateTime SinhNgay)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.SinhNgay == SinhNgay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectBySinhNgayLST_Paged(DateTime SinhNgay, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.SinhNgay == SinhNgay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySinhNgayRDT(DateTime SinhNgay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.SinhNgay == SinhNgay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySinhNgayRDT_Paged(DateTime SinhNgay, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.SinhNgay == SinhNgay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByChetNgayLST(DateTime ChetNgay)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.ChetNgay == ChetNgay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByChetNgayLST_Paged(DateTime ChetNgay, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.ChetNgay == ChetNgay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByChetNgayRDT(DateTime ChetNgay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.ChetNgay == ChetNgay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByChetNgayRDT_Paged(DateTime ChetNgay, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.ChetNgay == ChetNgay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByNoiSinhLST(string NoiSinh)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NoiSinh == NoiSinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByNoiSinhLST_Paged(string NoiSinh, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NoiSinh == NoiSinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNoiSinhRDT(string NoiSinh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NoiSinh == NoiSinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNoiSinhRDT_Paged(string NoiSinh, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NoiSinh == NoiSinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByQueQuanLST(string QueQuan)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.QueQuan == QueQuan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByQueQuanLST_Paged(string QueQuan, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.QueQuan == QueQuan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByQueQuanRDT(string QueQuan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.QueQuan == QueQuan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByQueQuanRDT_Paged(string QueQuan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.QueQuan == QueQuan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByNoiOLST(string NoiO)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NoiO == NoiO);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByNoiOLST_Paged(string NoiO, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NoiO == NoiO);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNoiORDT(string NoiO)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NoiO == NoiO);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNoiORDT_Paged(string NoiO, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NoiO == NoiO);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByNoiCuNguLST(string NoiCuNgu)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NoiCuNgu == NoiCuNgu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByNoiCuNguLST_Paged(string NoiCuNgu, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NoiCuNgu == NoiCuNgu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNoiCuNguRDT(string NoiCuNgu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NoiCuNgu == NoiCuNgu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNoiCuNguRDT_Paged(string NoiCuNgu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NoiCuNgu == NoiCuNgu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdQuocTichLST(Guid IdQuocTich)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdQuocTich == IdQuocTich);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdQuocTichLST_Paged(Guid IdQuocTich, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdQuocTich == IdQuocTich);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdQuocTichRDT(Guid IdQuocTich)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdQuocTich == IdQuocTich);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdQuocTichRDT_Paged(Guid IdQuocTich, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdQuocTich == IdQuocTich);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByCmndLST(string Cmnd)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.Cmnd == Cmnd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByCmndLST_Paged(string Cmnd, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.Cmnd == Cmnd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCmndRDT(string Cmnd)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.Cmnd == Cmnd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCmndRDT_Paged(string Cmnd, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.Cmnd == Cmnd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByNgayCapLST(DateTime NgayCap)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NgayCap == NgayCap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByNgayCapLST_Paged(DateTime NgayCap, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NgayCap == NgayCap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapRDT(DateTime NgayCap)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NgayCap == NgayCap);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapRDT_Paged(DateTime NgayCap, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NgayCap == NgayCap);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByNơiCapLST(string NơiCap)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NơiCap == NơiCap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByNơiCapLST_Paged(string NơiCap, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NơiCap == NơiCap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNơiCapRDT(string NơiCap)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NơiCap == NơiCap);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNơiCapRDT_Paged(string NơiCap, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NơiCap == NơiCap);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdDanTocLST(Guid IdDanToc)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdDanToc == IdDanToc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdDanTocLST_Paged(Guid IdDanToc, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdDanToc == IdDanToc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdDanTocRDT(Guid IdDanToc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdDanToc == IdDanToc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdDanTocRDT_Paged(Guid IdDanToc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdDanToc == IdDanToc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdTonGiaoLST(Guid IdTonGiao)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdTonGiao == IdTonGiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdTonGiaoLST_Paged(Guid IdTonGiao, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdTonGiao == IdTonGiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdTonGiaoRDT(Guid IdTonGiao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdTonGiao == IdTonGiao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdTonGiaoRDT_Paged(Guid IdTonGiao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdTonGiao == IdTonGiao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdChucSacLST(Guid IdChucSac)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdChucSac == IdChucSac);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdChucSacLST_Paged(Guid IdChucSac, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdChucSac == IdChucSac);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdChucSacRDT(Guid IdChucSac)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdChucSac == IdChucSac);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdChucSacRDT_Paged(Guid IdChucSac, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdChucSac == IdChucSac);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdTrinhDoHocVanLST(Guid IdTrinhDoHocVan)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdTrinhDoHocVan == IdTrinhDoHocVan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdTrinhDoHocVanLST_Paged(Guid IdTrinhDoHocVan, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdTrinhDoHocVan == IdTrinhDoHocVan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdTrinhDoHocVanRDT(Guid IdTrinhDoHocVan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdTrinhDoHocVan == IdTrinhDoHocVan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdTrinhDoHocVanRDT_Paged(Guid IdTrinhDoHocVan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdTrinhDoHocVan == IdTrinhDoHocVan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdNgheNghiepLST(Guid IdNgheNghiep)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdNgheNghiep == IdNgheNghiep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdNgheNghiepLST_Paged(Guid IdNgheNghiep, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdNgheNghiep == IdNgheNghiep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNgheNghiepRDT(Guid IdNgheNghiep)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdNgheNghiep == IdNgheNghiep);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNgheNghiepRDT_Paged(Guid IdNgheNghiep, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdNgheNghiep == IdNgheNghiep);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByHoTenChaLST(string HoTenCha)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HoTenCha == HoTenCha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByHoTenChaLST_Paged(string HoTenCha, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HoTenCha == HoTenCha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByHoTenChaRDT(string HoTenCha)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HoTenCha == HoTenCha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByHoTenChaRDT_Paged(string HoTenCha, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HoTenCha == HoTenCha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByHoTenMeLST(string HoTenMe)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HoTenMe == HoTenMe);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByHoTenMeLST_Paged(string HoTenMe, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HoTenMe == HoTenMe);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByHoTenMeRDT(string HoTenMe)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HoTenMe == HoTenMe);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByHoTenMeRDT_Paged(string HoTenMe, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HoTenMe == HoTenMe);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByHoTenVoChongLST(string HoTenVoChong)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HoTenVoChong == HoTenVoChong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByHoTenVoChongLST_Paged(string HoTenVoChong, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HoTenVoChong == HoTenVoChong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByHoTenVoChongRDT(string HoTenVoChong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HoTenVoChong == HoTenVoChong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByHoTenVoChongRDT_Paged(string HoTenVoChong, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HoTenVoChong == HoTenVoChong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByDacDiemDoiTuongLST(string DacDiemDoiTuong)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.DacDiemDoiTuong == DacDiemDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByDacDiemDoiTuongLST_Paged(string DacDiemDoiTuong, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.DacDiemDoiTuong == DacDiemDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDacDiemDoiTuongRDT(string DacDiemDoiTuong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.DacDiemDoiTuong == DacDiemDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDacDiemDoiTuongRDT_Paged(string DacDiemDoiTuong, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.DacDiemDoiTuong == DacDiemDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdTinhTrangChinhTriLST(Guid IdTinhTrangChinhTri)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdTinhTrangChinhTri == IdTinhTrangChinhTri);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdTinhTrangChinhTriLST_Paged(Guid IdTinhTrangChinhTri, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdTinhTrangChinhTri == IdTinhTrangChinhTri);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdTinhTrangChinhTriRDT(Guid IdTinhTrangChinhTri)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdTinhTrangChinhTri == IdTinhTrangChinhTri);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdTinhTrangChinhTriRDT_Paged(Guid IdTinhTrangChinhTri, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdTinhTrangChinhTri == IdTinhTrangChinhTri);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByTienAnLST(string TienAn)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.TienAn == TienAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByTienAnLST_Paged(string TienAn, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.TienAn == TienAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTienAnRDT(string TienAn)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.TienAn == TienAn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTienAnRDT_Paged(string TienAn, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.TienAn == TienAn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByNghienMaTuyLST(string NghienMaTuy)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NghienMaTuy == NghienMaTuy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByNghienMaTuyLST_Paged(string NghienMaTuy, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NghienMaTuy == NghienMaTuy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNghienMaTuyRDT(string NghienMaTuy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NghienMaTuy == NghienMaTuy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNghienMaTuyRDT_Paged(string NghienMaTuy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NghienMaTuy == NghienMaTuy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdLoaiDoiTuongLST(Guid IdLoaiDoiTuong)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdLoaiDoiTuong == IdLoaiDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdLoaiDoiTuongLST_Paged(Guid IdLoaiDoiTuong, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdLoaiDoiTuong == IdLoaiDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdLoaiDoiTuongRDT(Guid IdLoaiDoiTuong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdLoaiDoiTuong == IdLoaiDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdLoaiDoiTuongRDT_Paged(Guid IdLoaiDoiTuong, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdLoaiDoiTuong == IdLoaiDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdVaiTroTrongVuAnLST(Guid IdVaiTroTrongVuAn)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdVaiTroTrongVuAn == IdVaiTroTrongVuAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdVaiTroTrongVuAnLST_Paged(Guid IdVaiTroTrongVuAn, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdVaiTroTrongVuAn == IdVaiTroTrongVuAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdVaiTroTrongVuAnRDT(Guid IdVaiTroTrongVuAn)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdVaiTroTrongVuAn == IdVaiTroTrongVuAn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdVaiTroTrongVuAnRDT_Paged(Guid IdVaiTroTrongVuAn, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdVaiTroTrongVuAn == IdVaiTroTrongVuAn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdHanhViPhamToiLST(Guid IdHanhViPhamToi)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdHanhViPhamToi == IdHanhViPhamToi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdHanhViPhamToiLST_Paged(Guid IdHanhViPhamToi, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdHanhViPhamToi == IdHanhViPhamToi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdHanhViPhamToiRDT(Guid IdHanhViPhamToi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdHanhViPhamToi == IdHanhViPhamToi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdHanhViPhamToiRDT_Paged(Guid IdHanhViPhamToi, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdHanhViPhamToi == IdHanhViPhamToi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdQuyDinhHinhSuLST(Guid IdQuyDinhHinhSu)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdQuyDinhHinhSu == IdQuyDinhHinhSu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdQuyDinhHinhSuLST_Paged(Guid IdQuyDinhHinhSu, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdQuyDinhHinhSu == IdQuyDinhHinhSu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdQuyDinhHinhSuRDT(Guid IdQuyDinhHinhSu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdQuyDinhHinhSu == IdQuyDinhHinhSu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdQuyDinhHinhSuRDT_Paged(Guid IdQuyDinhHinhSu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdQuyDinhHinhSu == IdQuyDinhHinhSu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdTinhTrangTheTrangLST(Guid IdTinhTrangTheTrang)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdTinhTrangTheTrang == IdTinhTrangTheTrang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdTinhTrangTheTrangLST_Paged(Guid IdTinhTrangTheTrang, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdTinhTrangTheTrang == IdTinhTrangTheTrang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdTinhTrangTheTrangRDT(Guid IdTinhTrangTheTrang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdTinhTrangTheTrang == IdTinhTrangTheTrang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdTinhTrangTheTrangRDT_Paged(Guid IdTinhTrangTheTrang, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdTinhTrangTheTrang == IdTinhTrangTheTrang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdXuLyDoiTuongLST(Guid IdXuLyDoiTuong)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdXuLyDoiTuong == IdXuLyDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdXuLyDoiTuongLST_Paged(Guid IdXuLyDoiTuong, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdXuLyDoiTuong == IdXuLyDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdXuLyDoiTuongRDT(Guid IdXuLyDoiTuong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdXuLyDoiTuong == IdXuLyDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdXuLyDoiTuongRDT_Paged(Guid IdXuLyDoiTuong, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdXuLyDoiTuong == IdXuLyDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdTruongHopBatLST(Guid IdTruongHopBat)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdTruongHopBat == IdTruongHopBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdTruongHopBatLST_Paged(Guid IdTruongHopBat, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdTruongHopBat == IdTruongHopBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdTruongHopBatRDT(Guid IdTruongHopBat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdTruongHopBat == IdTruongHopBat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdTruongHopBatRDT_Paged(Guid IdTruongHopBat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdTruongHopBat == IdTruongHopBat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdTinhTrangBatLST(Guid IdTinhTrangBat)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdTinhTrangBat == IdTinhTrangBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdTinhTrangBatLST_Paged(Guid IdTinhTrangBat, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdTinhTrangBat == IdTinhTrangBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdTinhTrangBatRDT(Guid IdTinhTrangBat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdTinhTrangBat == IdTinhTrangBat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdTinhTrangBatRDT_Paged(Guid IdTinhTrangBat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdTinhTrangBat == IdTinhTrangBat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByNgayBatLST(DateTime NgayBat)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NgayBat == NgayBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByNgayBatLST_Paged(DateTime NgayBat, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NgayBat == NgayBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayBatRDT(DateTime NgayBat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NgayBat == NgayBat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayBatRDT_Paged(DateTime NgayBat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NgayBat == NgayBat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByThongTinKhacLST(string ThongTinKhac)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.ThongTinKhac == ThongTinKhac);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByThongTinKhacLST_Paged(string ThongTinKhac, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.ThongTinKhac == ThongTinKhac);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByThongTinKhacRDT(string ThongTinKhac)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.ThongTinKhac == ThongTinKhac);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByThongTinKhacRDT_Paged(string ThongTinKhac, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.ThongTinKhac == ThongTinKhac);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByTienSuLST(string TienSu)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.TienSu == TienSu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByTienSuLST_Paged(string TienSu, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.TienSu == TienSu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTienSuRDT(string TienSu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.TienSu == TienSu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTienSuRDT_Paged(string TienSu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.TienSu == TienSu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectBySoHoSoLST(string SoHoSo)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.SoHoSo == SoHoSo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectBySoHoSoLST_Paged(string SoHoSo, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.SoHoSo == SoHoSo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySoHoSoRDT(string SoHoSo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.SoHoSo == SoHoSo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySoHoSoRDT_Paged(string SoHoSo, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.SoHoSo == SoHoSo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByHkttLST(string Hktt)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.Hktt == Hktt);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByHkttLST_Paged(string Hktt, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.Hktt == Hktt);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByHkttRDT(string Hktt)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.Hktt == Hktt);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByHkttRDT_Paged(string Hktt, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.Hktt == Hktt);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByTamTruLST(string TamTru)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.TamTru == TamTru);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByTamTruLST_Paged(string TamTru, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.TamTru == TamTru);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTamTruRDT(string TamTru)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.TamTru == TamTru);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTamTruRDT_Paged(string TamTru, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.TamTru == TamTru);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByNoiLamViecLST(string NoiLamViec)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NoiLamViec == NoiLamViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByNoiLamViecLST_Paged(string NoiLamViec, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NoiLamViec == NoiLamViec);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNoiLamViecRDT(string NoiLamViec)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NoiLamViec == NoiLamViec);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNoiLamViecRDT_Paged(string NoiLamViec, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NoiLamViec == NoiLamViec);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByChucVuLST(string ChucVu)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.ChucVu == ChucVu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByChucVuLST_Paged(string ChucVu, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.ChucVu == ChucVu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByChucVuRDT(string ChucVu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.ChucVu == ChucVu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByChucVuRDT_Paged(string ChucVu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.ChucVu == ChucVu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectBySoDienThoaiLST(string SoDienThoai)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.SoDienThoai == SoDienThoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectBySoDienThoaiLST_Paged(string SoDienThoai, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.SoDienThoai == SoDienThoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySoDienThoaiRDT(string SoDienThoai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.SoDienThoai == SoDienThoai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySoDienThoaiRDT_Paged(string SoDienThoai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.SoDienThoai == SoDienThoai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByFaxLST(string Fax)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.Fax == Fax);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByFaxLST_Paged(string Fax, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.Fax == Fax);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByFaxRDT(string Fax)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.Fax == Fax);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByFaxRDT_Paged(string Fax, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.Fax == Fax);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByEmailLST(string Email)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByEmailLST_Paged(string Email, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByEmailRDT(string Email)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByEmailRDT_Paged(string Email, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByPassportLST(string Passport)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.Passport == Passport);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByPassportLST_Paged(string Passport, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.Passport == Passport);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPassportRDT(string Passport)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.Passport == Passport);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPassportRDT_Paged(string Passport, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.Passport == Passport);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByQuanHeCanChuYLST(string QuanHeCanChuY)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.QuanHeCanChuY == QuanHeCanChuY);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByQuanHeCanChuYLST_Paged(string QuanHeCanChuY, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.QuanHeCanChuY == QuanHeCanChuY);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByQuanHeCanChuYRDT(string QuanHeCanChuY)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.QuanHeCanChuY == QuanHeCanChuY);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByQuanHeCanChuYRDT_Paged(string QuanHeCanChuY, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.QuanHeCanChuY == QuanHeCanChuY);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByHinhAnhLST(string HinhAnh)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HinhAnh == HinhAnh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByHinhAnhLST_Paged(string HinhAnh, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HinhAnh == HinhAnh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByHinhAnhRDT(string HinhAnh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HinhAnh == HinhAnh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByHinhAnhRDT_Paged(string HinhAnh, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HinhAnh == HinhAnh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByHoSoThanNhanLST(string HoSoThanNhan)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HoSoThanNhan == HoSoThanNhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByHoSoThanNhanLST_Paged(string HoSoThanNhan, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HoSoThanNhan == HoSoThanNhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByHoSoThanNhanRDT(string HoSoThanNhan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HoSoThanNhan == HoSoThanNhan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByHoSoThanNhanRDT_Paged(string HoSoThanNhan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.HoSoThanNhan == HoSoThanNhan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByTrangThaiBatLST(string TrangThaiBat)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.TrangThaiBat == TrangThaiBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByTrangThaiBatLST_Paged(string TrangThaiBat, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.TrangThaiBat == TrangThaiBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiBatRDT(string TrangThaiBat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.TrangThaiBat == TrangThaiBat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiBatRDT_Paged(string TrangThaiBat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.TrangThaiBat == TrangThaiBat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdDonViBatLST(Guid IdDonViBat)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdDonViBat == IdDonViBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdDonViBatLST_Paged(Guid IdDonViBat, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdDonViBat == IdDonViBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdDonViBatRDT(Guid IdDonViBat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdDonViBat == IdDonViBat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdDonViBatRDT_Paged(Guid IdDonViBat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdDonViBat == IdDonViBat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null);
			}
			return _DoiTuongCollection;
		}
		
		// Return EntityCollection<DoiTuongEntity>
		public EntityCollection<DoiTuongEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<DoiTuongEntity> _DoiTuongCollection = new EntityCollection<DoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DoiTuongCollection = new EntityCollection(new DoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
