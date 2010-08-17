




/*
'===============================================================================
'  LayerHelper.CAQ.BL.TaiKhoanNguoiDungManagerBase
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
	public class TaiKhoanNguoiDungManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TaiKhoanNguoiDungManagerBase()
		{
			// Nothing for now.
		}
		
		public TaiKhoanNguoiDungEntity Insert(TaiKhoanNguoiDungEntity _TaiKhoanNguoiDungEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_TaiKhoanNguoiDungEntity, true);
			}
			return _TaiKhoanNguoiDungEntity;
		}

		
		public TaiKhoanNguoiDungEntity Insert(Guid Id, string TenDangNhap, string MatKhau, DateTime NgayDangKy, DateTime NgayHetHan, string HoTen, string MaRutGon, string BiDanh, DateTime NgaySinh, string DiaChiNoiO, Guid IdGioiTinh, string QueQuan, Guid IdDonVi, Guid IdChucVu, Guid IdDanToc, Guid IdTonGiao, Guid IdQuocTich, Guid IdTrinhDoHocVan, string Cmnd, string ThongTinKhac, string ThuDienTu, string LoaiTaiKhoan, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			TaiKhoanNguoiDungEntity _TaiKhoanNguoiDungEntity = new TaiKhoanNguoiDungEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_TaiKhoanNguoiDungEntity.Id = Id;
				_TaiKhoanNguoiDungEntity.TenDangNhap = TenDangNhap;
				_TaiKhoanNguoiDungEntity.MatKhau = MatKhau;
				_TaiKhoanNguoiDungEntity.NgayDangKy = NgayDangKy;
				_TaiKhoanNguoiDungEntity.NgayHetHan = NgayHetHan;
				_TaiKhoanNguoiDungEntity.HoTen = HoTen;
				_TaiKhoanNguoiDungEntity.MaRutGon = MaRutGon;
				_TaiKhoanNguoiDungEntity.BiDanh = BiDanh;
				_TaiKhoanNguoiDungEntity.NgaySinh = NgaySinh;
				_TaiKhoanNguoiDungEntity.DiaChiNoiO = DiaChiNoiO;
				_TaiKhoanNguoiDungEntity.IdGioiTinh = IdGioiTinh;
				_TaiKhoanNguoiDungEntity.QueQuan = QueQuan;
				_TaiKhoanNguoiDungEntity.IdDonVi = IdDonVi;
				_TaiKhoanNguoiDungEntity.IdChucVu = IdChucVu;
				_TaiKhoanNguoiDungEntity.IdDanToc = IdDanToc;
				_TaiKhoanNguoiDungEntity.IdTonGiao = IdTonGiao;
				_TaiKhoanNguoiDungEntity.IdQuocTich = IdQuocTich;
				_TaiKhoanNguoiDungEntity.IdTrinhDoHocVan = IdTrinhDoHocVan;
				_TaiKhoanNguoiDungEntity.Cmnd = Cmnd;
				_TaiKhoanNguoiDungEntity.ThongTinKhac = ThongTinKhac;
				_TaiKhoanNguoiDungEntity.ThuDienTu = ThuDienTu;
				_TaiKhoanNguoiDungEntity.LoaiTaiKhoan = LoaiTaiKhoan;
				_TaiKhoanNguoiDungEntity.IdNguoiTao = IdNguoiTao;
				_TaiKhoanNguoiDungEntity.NgayTao = NgayTao;
				_TaiKhoanNguoiDungEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_TaiKhoanNguoiDungEntity.NgayCapNhat = NgayCapNhat;
				_TaiKhoanNguoiDungEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_TaiKhoanNguoiDungEntity, true);
			}
			return _TaiKhoanNguoiDungEntity;
		}

		public TaiKhoanNguoiDungEntity Insert(string TenDangNhap, string MatKhau, DateTime NgayDangKy, DateTime NgayHetHan, string HoTen, string MaRutGon, string BiDanh, DateTime NgaySinh, string DiaChiNoiO, Guid IdGioiTinh, string QueQuan, Guid IdDonVi, Guid IdChucVu, Guid IdDanToc, Guid IdTonGiao, Guid IdQuocTich, Guid IdTrinhDoHocVan, string Cmnd, string ThongTinKhac, string ThuDienTu, string LoaiTaiKhoan, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			TaiKhoanNguoiDungEntity _TaiKhoanNguoiDungEntity = new TaiKhoanNguoiDungEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_TaiKhoanNguoiDungEntity.TenDangNhap = TenDangNhap;
				_TaiKhoanNguoiDungEntity.MatKhau = MatKhau;
				_TaiKhoanNguoiDungEntity.NgayDangKy = NgayDangKy;
				_TaiKhoanNguoiDungEntity.NgayHetHan = NgayHetHan;
				_TaiKhoanNguoiDungEntity.HoTen = HoTen;
				_TaiKhoanNguoiDungEntity.MaRutGon = MaRutGon;
				_TaiKhoanNguoiDungEntity.BiDanh = BiDanh;
				_TaiKhoanNguoiDungEntity.NgaySinh = NgaySinh;
				_TaiKhoanNguoiDungEntity.DiaChiNoiO = DiaChiNoiO;
				_TaiKhoanNguoiDungEntity.IdGioiTinh = IdGioiTinh;
				_TaiKhoanNguoiDungEntity.QueQuan = QueQuan;
				_TaiKhoanNguoiDungEntity.IdDonVi = IdDonVi;
				_TaiKhoanNguoiDungEntity.IdChucVu = IdChucVu;
				_TaiKhoanNguoiDungEntity.IdDanToc = IdDanToc;
				_TaiKhoanNguoiDungEntity.IdTonGiao = IdTonGiao;
				_TaiKhoanNguoiDungEntity.IdQuocTich = IdQuocTich;
				_TaiKhoanNguoiDungEntity.IdTrinhDoHocVan = IdTrinhDoHocVan;
				_TaiKhoanNguoiDungEntity.Cmnd = Cmnd;
				_TaiKhoanNguoiDungEntity.ThongTinKhac = ThongTinKhac;
				_TaiKhoanNguoiDungEntity.ThuDienTu = ThuDienTu;
				_TaiKhoanNguoiDungEntity.LoaiTaiKhoan = LoaiTaiKhoan;
				_TaiKhoanNguoiDungEntity.IdNguoiTao = IdNguoiTao;
				_TaiKhoanNguoiDungEntity.NgayTao = NgayTao;
				_TaiKhoanNguoiDungEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_TaiKhoanNguoiDungEntity.NgayCapNhat = NgayCapNhat;
				_TaiKhoanNguoiDungEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_TaiKhoanNguoiDungEntity, true);
			}
			return _TaiKhoanNguoiDungEntity;
		}

		public bool Update(TaiKhoanNguoiDungEntity _TaiKhoanNguoiDungEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(TaiKhoanNguoiDungFields.Id == _TaiKhoanNguoiDungEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_TaiKhoanNguoiDungEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(TaiKhoanNguoiDungEntity _TaiKhoanNguoiDungEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_TaiKhoanNguoiDungEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenDangNhap, string MatKhau, DateTime NgayDangKy, DateTime NgayHetHan, string HoTen, string MaRutGon, string BiDanh, DateTime NgaySinh, string DiaChiNoiO, Guid IdGioiTinh, string QueQuan, Guid IdDonVi, Guid IdChucVu, Guid IdDanToc, Guid IdTonGiao, Guid IdQuocTich, Guid IdTrinhDoHocVan, string Cmnd, string ThongTinKhac, string ThuDienTu, string LoaiTaiKhoan, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TaiKhoanNguoiDungEntity _TaiKhoanNguoiDungEntity = new TaiKhoanNguoiDungEntity(Id);
				if (adapter.FetchEntity(_TaiKhoanNguoiDungEntity))
				{
				
					_TaiKhoanNguoiDungEntity.TenDangNhap = TenDangNhap;
					_TaiKhoanNguoiDungEntity.MatKhau = MatKhau;
					_TaiKhoanNguoiDungEntity.NgayDangKy = NgayDangKy;
					_TaiKhoanNguoiDungEntity.NgayHetHan = NgayHetHan;
					_TaiKhoanNguoiDungEntity.HoTen = HoTen;
					_TaiKhoanNguoiDungEntity.MaRutGon = MaRutGon;
					_TaiKhoanNguoiDungEntity.BiDanh = BiDanh;
					_TaiKhoanNguoiDungEntity.NgaySinh = NgaySinh;
					_TaiKhoanNguoiDungEntity.DiaChiNoiO = DiaChiNoiO;
					_TaiKhoanNguoiDungEntity.IdGioiTinh = IdGioiTinh;
					_TaiKhoanNguoiDungEntity.QueQuan = QueQuan;
					_TaiKhoanNguoiDungEntity.IdDonVi = IdDonVi;
					_TaiKhoanNguoiDungEntity.IdChucVu = IdChucVu;
					_TaiKhoanNguoiDungEntity.IdDanToc = IdDanToc;
					_TaiKhoanNguoiDungEntity.IdTonGiao = IdTonGiao;
					_TaiKhoanNguoiDungEntity.IdQuocTich = IdQuocTich;
					_TaiKhoanNguoiDungEntity.IdTrinhDoHocVan = IdTrinhDoHocVan;
					_TaiKhoanNguoiDungEntity.Cmnd = Cmnd;
					_TaiKhoanNguoiDungEntity.ThongTinKhac = ThongTinKhac;
					_TaiKhoanNguoiDungEntity.ThuDienTu = ThuDienTu;
					_TaiKhoanNguoiDungEntity.LoaiTaiKhoan = LoaiTaiKhoan;
					_TaiKhoanNguoiDungEntity.IdNguoiTao = IdNguoiTao;
					_TaiKhoanNguoiDungEntity.NgayTao = NgayTao;
					_TaiKhoanNguoiDungEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_TaiKhoanNguoiDungEntity.NgayCapNhat = NgayCapNhat;
					_TaiKhoanNguoiDungEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_TaiKhoanNguoiDungEntity, true);
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
				TaiKhoanNguoiDungEntity _TaiKhoanNguoiDungEntity = new TaiKhoanNguoiDungEntity(Id);
				if (adapter.FetchEntity(_TaiKhoanNguoiDungEntity))
				{
					adapter.DeleteEntity(_TaiKhoanNguoiDungEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("TaiKhoanNguoiDungEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TaiKhoanNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenDangNhap(string TenDangNhap)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.TenDangNhap == TenDangNhap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TaiKhoanNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMatKhau(string MatKhau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.MatKhau == MatKhau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TaiKhoanNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayDangKy(DateTime NgayDangKy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.NgayDangKy == NgayDangKy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TaiKhoanNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TaiKhoanNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByHoTen(string HoTen)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.HoTen == HoTen);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TaiKhoanNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TaiKhoanNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByBiDanh(string BiDanh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.BiDanh == BiDanh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TaiKhoanNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgaySinh(DateTime NgaySinh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.NgaySinh == NgaySinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TaiKhoanNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDiaChiNoiO(string DiaChiNoiO)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.DiaChiNoiO == DiaChiNoiO);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TaiKhoanNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdGioiTinh(Guid IdGioiTinh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdGioiTinh == IdGioiTinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TaiKhoanNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByQueQuan(string QueQuan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.QueQuan == QueQuan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TaiKhoanNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdDonVi(Guid IdDonVi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdDonVi == IdDonVi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TaiKhoanNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdChucVu(Guid IdChucVu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdChucVu == IdChucVu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TaiKhoanNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdDanToc(Guid IdDanToc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdDanToc == IdDanToc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TaiKhoanNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdTonGiao(Guid IdTonGiao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdTonGiao == IdTonGiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TaiKhoanNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdQuocTich(Guid IdQuocTich)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdQuocTich == IdQuocTich);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TaiKhoanNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdTrinhDoHocVan(Guid IdTrinhDoHocVan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdTrinhDoHocVan == IdTrinhDoHocVan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TaiKhoanNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCmnd(string Cmnd)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.Cmnd == Cmnd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TaiKhoanNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByThongTinKhac(string ThongTinKhac)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.ThongTinKhac == ThongTinKhac);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TaiKhoanNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByThuDienTu(string ThuDienTu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.ThuDienTu == ThuDienTu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TaiKhoanNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiTaiKhoan(string LoaiTaiKhoan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.LoaiTaiKhoan == LoaiTaiKhoan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TaiKhoanNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TaiKhoanNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TaiKhoanNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TaiKhoanNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TaiKhoanNguoiDungEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TaiKhoanNguoiDungEntity", filter);
			}
			return toReturn;
		}
		

		
		public TaiKhoanNguoiDungEntity SelectOne(Guid Id)
		{
			TaiKhoanNguoiDungEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TaiKhoanNguoiDungEntity _TaiKhoanNguoiDungEntity = new TaiKhoanNguoiDungEntity(Id);
				if (adapter.FetchEntity(_TaiKhoanNguoiDungEntity))
				{
					toReturn = _TaiKhoanNguoiDungEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectAllLST()
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, null, 0, null);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _TaiKhoanNguoiDungCollection;
		}


		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByTenDangNhapLST(string TenDangNhap)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.TenDangNhap == TenDangNhap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByTenDangNhapLST_Paged(string TenDangNhap, int PageNumber, int PageSize)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.TenDangNhap == TenDangNhap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenDangNhapRDT(string TenDangNhap)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.TenDangNhap == TenDangNhap);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenDangNhapRDT_Paged(string TenDangNhap, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.TenDangNhap == TenDangNhap);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByMatKhauLST(string MatKhau)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.MatKhau == MatKhau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByMatKhauLST_Paged(string MatKhau, int PageNumber, int PageSize)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.MatKhau == MatKhau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMatKhauRDT(string MatKhau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.MatKhau == MatKhau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMatKhauRDT_Paged(string MatKhau, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.MatKhau == MatKhau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByNgayDangKyLST(DateTime NgayDangKy)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.NgayDangKy == NgayDangKy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByNgayDangKyLST_Paged(DateTime NgayDangKy, int PageNumber, int PageSize)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.NgayDangKy == NgayDangKy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayDangKyRDT(DateTime NgayDangKy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.NgayDangKy == NgayDangKy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayDangKyRDT_Paged(DateTime NgayDangKy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.NgayDangKy == NgayDangKy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByHoTenLST(string HoTen)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.HoTen == HoTen);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByHoTenLST_Paged(string HoTen, int PageNumber, int PageSize)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.HoTen == HoTen);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByHoTenRDT(string HoTen)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.HoTen == HoTen);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByHoTenRDT_Paged(string HoTen, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.HoTen == HoTen);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByBiDanhLST(string BiDanh)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.BiDanh == BiDanh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByBiDanhLST_Paged(string BiDanh, int PageNumber, int PageSize)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.BiDanh == BiDanh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByBiDanhRDT(string BiDanh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.BiDanh == BiDanh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByBiDanhRDT_Paged(string BiDanh, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.BiDanh == BiDanh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByNgaySinhLST(DateTime NgaySinh)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.NgaySinh == NgaySinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByNgaySinhLST_Paged(DateTime NgaySinh, int PageNumber, int PageSize)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.NgaySinh == NgaySinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgaySinhRDT(DateTime NgaySinh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.NgaySinh == NgaySinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgaySinhRDT_Paged(DateTime NgaySinh, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.NgaySinh == NgaySinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByDiaChiNoiOLST(string DiaChiNoiO)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.DiaChiNoiO == DiaChiNoiO);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByDiaChiNoiOLST_Paged(string DiaChiNoiO, int PageNumber, int PageSize)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.DiaChiNoiO == DiaChiNoiO);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDiaChiNoiORDT(string DiaChiNoiO)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.DiaChiNoiO == DiaChiNoiO);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDiaChiNoiORDT_Paged(string DiaChiNoiO, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.DiaChiNoiO == DiaChiNoiO);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByIdGioiTinhLST(Guid IdGioiTinh)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdGioiTinh == IdGioiTinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByIdGioiTinhLST_Paged(Guid IdGioiTinh, int PageNumber, int PageSize)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdGioiTinh == IdGioiTinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdGioiTinhRDT(Guid IdGioiTinh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdGioiTinh == IdGioiTinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdGioiTinhRDT_Paged(Guid IdGioiTinh, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdGioiTinh == IdGioiTinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByQueQuanLST(string QueQuan)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.QueQuan == QueQuan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByQueQuanLST_Paged(string QueQuan, int PageNumber, int PageSize)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.QueQuan == QueQuan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByQueQuanRDT(string QueQuan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.QueQuan == QueQuan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByQueQuanRDT_Paged(string QueQuan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.QueQuan == QueQuan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByIdDonViLST(Guid IdDonVi)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdDonVi == IdDonVi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByIdDonViLST_Paged(Guid IdDonVi, int PageNumber, int PageSize)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdDonVi == IdDonVi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdDonViRDT(Guid IdDonVi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdDonVi == IdDonVi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdDonViRDT_Paged(Guid IdDonVi, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdDonVi == IdDonVi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByIdChucVuLST(Guid IdChucVu)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdChucVu == IdChucVu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByIdChucVuLST_Paged(Guid IdChucVu, int PageNumber, int PageSize)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdChucVu == IdChucVu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdChucVuRDT(Guid IdChucVu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdChucVu == IdChucVu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdChucVuRDT_Paged(Guid IdChucVu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdChucVu == IdChucVu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByIdDanTocLST(Guid IdDanToc)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdDanToc == IdDanToc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByIdDanTocLST_Paged(Guid IdDanToc, int PageNumber, int PageSize)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdDanToc == IdDanToc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdDanTocRDT(Guid IdDanToc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdDanToc == IdDanToc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdDanTocRDT_Paged(Guid IdDanToc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdDanToc == IdDanToc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByIdTonGiaoLST(Guid IdTonGiao)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdTonGiao == IdTonGiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByIdTonGiaoLST_Paged(Guid IdTonGiao, int PageNumber, int PageSize)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdTonGiao == IdTonGiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdTonGiaoRDT(Guid IdTonGiao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdTonGiao == IdTonGiao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdTonGiaoRDT_Paged(Guid IdTonGiao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdTonGiao == IdTonGiao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByIdQuocTichLST(Guid IdQuocTich)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdQuocTich == IdQuocTich);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByIdQuocTichLST_Paged(Guid IdQuocTich, int PageNumber, int PageSize)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdQuocTich == IdQuocTich);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdQuocTichRDT(Guid IdQuocTich)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdQuocTich == IdQuocTich);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdQuocTichRDT_Paged(Guid IdQuocTich, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdQuocTich == IdQuocTich);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByIdTrinhDoHocVanLST(Guid IdTrinhDoHocVan)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdTrinhDoHocVan == IdTrinhDoHocVan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByIdTrinhDoHocVanLST_Paged(Guid IdTrinhDoHocVan, int PageNumber, int PageSize)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdTrinhDoHocVan == IdTrinhDoHocVan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdTrinhDoHocVanRDT(Guid IdTrinhDoHocVan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdTrinhDoHocVan == IdTrinhDoHocVan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdTrinhDoHocVanRDT_Paged(Guid IdTrinhDoHocVan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdTrinhDoHocVan == IdTrinhDoHocVan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByCmndLST(string Cmnd)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.Cmnd == Cmnd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByCmndLST_Paged(string Cmnd, int PageNumber, int PageSize)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.Cmnd == Cmnd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCmndRDT(string Cmnd)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.Cmnd == Cmnd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCmndRDT_Paged(string Cmnd, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.Cmnd == Cmnd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByThongTinKhacLST(string ThongTinKhac)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.ThongTinKhac == ThongTinKhac);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByThongTinKhacLST_Paged(string ThongTinKhac, int PageNumber, int PageSize)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.ThongTinKhac == ThongTinKhac);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByThongTinKhacRDT(string ThongTinKhac)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.ThongTinKhac == ThongTinKhac);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByThongTinKhacRDT_Paged(string ThongTinKhac, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.ThongTinKhac == ThongTinKhac);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByThuDienTuLST(string ThuDienTu)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.ThuDienTu == ThuDienTu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByThuDienTuLST_Paged(string ThuDienTu, int PageNumber, int PageSize)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.ThuDienTu == ThuDienTu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByThuDienTuRDT(string ThuDienTu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.ThuDienTu == ThuDienTu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByThuDienTuRDT_Paged(string ThuDienTu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.ThuDienTu == ThuDienTu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByLoaiTaiKhoanLST(string LoaiTaiKhoan)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.LoaiTaiKhoan == LoaiTaiKhoan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByLoaiTaiKhoanLST_Paged(string LoaiTaiKhoan, int PageNumber, int PageSize)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.LoaiTaiKhoan == LoaiTaiKhoan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiTaiKhoanRDT(string LoaiTaiKhoan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.LoaiTaiKhoan == LoaiTaiKhoan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiTaiKhoanRDT_Paged(string LoaiTaiKhoan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.LoaiTaiKhoan == LoaiTaiKhoan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return EntityCollection<TaiKhoanNguoiDungEntity>
		public EntityCollection<TaiKhoanNguoiDungEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<TaiKhoanNguoiDungEntity> _TaiKhoanNguoiDungCollection = new EntityCollection<TaiKhoanNguoiDungEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TaiKhoanNguoiDungCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TaiKhoanNguoiDungCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TaiKhoanNguoiDungCollection = new EntityCollection(new TaiKhoanNguoiDungEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TaiKhoanNguoiDungFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TaiKhoanNguoiDungCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
