




/*
'===============================================================================
'  LayerHelper.CAQ.BL.TienSuDoiTuongManagerBase
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
	public class TienSuDoiTuongManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TienSuDoiTuongManagerBase()
		{
			// Nothing for now.
		}
		
		public TienSuDoiTuongEntity Insert(TienSuDoiTuongEntity _TienSuDoiTuongEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_TienSuDoiTuongEntity, true);
			}
			return _TienSuDoiTuongEntity;
		}

		
		public TienSuDoiTuongEntity Insert(Guid Id, Guid IdDoiTuong, Guid IdXuLyHanhChinh, Guid IdHanhVi, string SoQuyDinh, DateTime NgayQuyDinh, DateTime NgayBatDau, DateTime NgayKetThuc, decimal MucPhatTien, string SoXl135, DateTime NgayXl135, Guid IdCscb, DateTime NgayTron, DateTime NgayBatLai, string SoQuyDinhTruyTim, DateTime NgayQuyDinhTruyTim, string SoQuyDinhHoaNhap, DateTime NgayQuyDinhHoaNhap, DateTime NgayVeDiaPhuong, string SoQuyDinhTaiNghien, DateTime NgayQuyDinhTaiNghien, Guid IdQuanLy, string TongHop, string MaRutGon, string MaTp, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			TienSuDoiTuongEntity _TienSuDoiTuongEntity = new TienSuDoiTuongEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_TienSuDoiTuongEntity.Id = Id;
				_TienSuDoiTuongEntity.IdDoiTuong = IdDoiTuong;
				_TienSuDoiTuongEntity.IdXuLyHanhChinh = IdXuLyHanhChinh;
				_TienSuDoiTuongEntity.IdHanhVi = IdHanhVi;
				_TienSuDoiTuongEntity.SoQuyDinh = SoQuyDinh;
				_TienSuDoiTuongEntity.NgayQuyDinh = NgayQuyDinh;
				_TienSuDoiTuongEntity.NgayBatDau = NgayBatDau;
				_TienSuDoiTuongEntity.NgayKetThuc = NgayKetThuc;
				_TienSuDoiTuongEntity.MucPhatTien = MucPhatTien;
				_TienSuDoiTuongEntity.SoXl135 = SoXl135;
				_TienSuDoiTuongEntity.NgayXl135 = NgayXl135;
				_TienSuDoiTuongEntity.IdCscb = IdCscb;
				_TienSuDoiTuongEntity.NgayTron = NgayTron;
				_TienSuDoiTuongEntity.NgayBatLai = NgayBatLai;
				_TienSuDoiTuongEntity.SoQuyDinhTruyTim = SoQuyDinhTruyTim;
				_TienSuDoiTuongEntity.NgayQuyDinhTruyTim = NgayQuyDinhTruyTim;
				_TienSuDoiTuongEntity.SoQuyDinhHoaNhap = SoQuyDinhHoaNhap;
				_TienSuDoiTuongEntity.NgayQuyDinhHoaNhap = NgayQuyDinhHoaNhap;
				_TienSuDoiTuongEntity.NgayVeDiaPhuong = NgayVeDiaPhuong;
				_TienSuDoiTuongEntity.SoQuyDinhTaiNghien = SoQuyDinhTaiNghien;
				_TienSuDoiTuongEntity.NgayQuyDinhTaiNghien = NgayQuyDinhTaiNghien;
				_TienSuDoiTuongEntity.IdQuanLy = IdQuanLy;
				_TienSuDoiTuongEntity.TongHop = TongHop;
				_TienSuDoiTuongEntity.MaRutGon = MaRutGon;
				_TienSuDoiTuongEntity.MaTp = MaTp;
				_TienSuDoiTuongEntity.LoaiDanhMuc = LoaiDanhMuc;
				_TienSuDoiTuongEntity.IdNguoiTao = IdNguoiTao;
				_TienSuDoiTuongEntity.NgayTao = NgayTao;
				_TienSuDoiTuongEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_TienSuDoiTuongEntity.NgayCapNhat = NgayCapNhat;
				_TienSuDoiTuongEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_TienSuDoiTuongEntity, true);
			}
			return _TienSuDoiTuongEntity;
		}

		public TienSuDoiTuongEntity Insert(Guid IdDoiTuong, Guid IdXuLyHanhChinh, Guid IdHanhVi, string SoQuyDinh, DateTime NgayQuyDinh, DateTime NgayBatDau, DateTime NgayKetThuc, decimal MucPhatTien, string SoXl135, DateTime NgayXl135, Guid IdCscb, DateTime NgayTron, DateTime NgayBatLai, string SoQuyDinhTruyTim, DateTime NgayQuyDinhTruyTim, string SoQuyDinhHoaNhap, DateTime NgayQuyDinhHoaNhap, DateTime NgayVeDiaPhuong, string SoQuyDinhTaiNghien, DateTime NgayQuyDinhTaiNghien, Guid IdQuanLy, string TongHop, string MaRutGon, string MaTp, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			TienSuDoiTuongEntity _TienSuDoiTuongEntity = new TienSuDoiTuongEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_TienSuDoiTuongEntity.IdDoiTuong = IdDoiTuong;
				_TienSuDoiTuongEntity.IdXuLyHanhChinh = IdXuLyHanhChinh;
				_TienSuDoiTuongEntity.IdHanhVi = IdHanhVi;
				_TienSuDoiTuongEntity.SoQuyDinh = SoQuyDinh;
				_TienSuDoiTuongEntity.NgayQuyDinh = NgayQuyDinh;
				_TienSuDoiTuongEntity.NgayBatDau = NgayBatDau;
				_TienSuDoiTuongEntity.NgayKetThuc = NgayKetThuc;
				_TienSuDoiTuongEntity.MucPhatTien = MucPhatTien;
				_TienSuDoiTuongEntity.SoXl135 = SoXl135;
				_TienSuDoiTuongEntity.NgayXl135 = NgayXl135;
				_TienSuDoiTuongEntity.IdCscb = IdCscb;
				_TienSuDoiTuongEntity.NgayTron = NgayTron;
				_TienSuDoiTuongEntity.NgayBatLai = NgayBatLai;
				_TienSuDoiTuongEntity.SoQuyDinhTruyTim = SoQuyDinhTruyTim;
				_TienSuDoiTuongEntity.NgayQuyDinhTruyTim = NgayQuyDinhTruyTim;
				_TienSuDoiTuongEntity.SoQuyDinhHoaNhap = SoQuyDinhHoaNhap;
				_TienSuDoiTuongEntity.NgayQuyDinhHoaNhap = NgayQuyDinhHoaNhap;
				_TienSuDoiTuongEntity.NgayVeDiaPhuong = NgayVeDiaPhuong;
				_TienSuDoiTuongEntity.SoQuyDinhTaiNghien = SoQuyDinhTaiNghien;
				_TienSuDoiTuongEntity.NgayQuyDinhTaiNghien = NgayQuyDinhTaiNghien;
				_TienSuDoiTuongEntity.IdQuanLy = IdQuanLy;
				_TienSuDoiTuongEntity.TongHop = TongHop;
				_TienSuDoiTuongEntity.MaRutGon = MaRutGon;
				_TienSuDoiTuongEntity.MaTp = MaTp;
				_TienSuDoiTuongEntity.LoaiDanhMuc = LoaiDanhMuc;
				_TienSuDoiTuongEntity.IdNguoiTao = IdNguoiTao;
				_TienSuDoiTuongEntity.NgayTao = NgayTao;
				_TienSuDoiTuongEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_TienSuDoiTuongEntity.NgayCapNhat = NgayCapNhat;
				_TienSuDoiTuongEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_TienSuDoiTuongEntity, true);
			}
			return _TienSuDoiTuongEntity;
		}

		public bool Update(TienSuDoiTuongEntity _TienSuDoiTuongEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(TienSuDoiTuongFields.Id == _TienSuDoiTuongEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_TienSuDoiTuongEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(TienSuDoiTuongEntity _TienSuDoiTuongEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_TienSuDoiTuongEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid IdDoiTuong, Guid IdXuLyHanhChinh, Guid IdHanhVi, string SoQuyDinh, DateTime NgayQuyDinh, DateTime NgayBatDau, DateTime NgayKetThuc, decimal MucPhatTien, string SoXl135, DateTime NgayXl135, Guid IdCscb, DateTime NgayTron, DateTime NgayBatLai, string SoQuyDinhTruyTim, DateTime NgayQuyDinhTruyTim, string SoQuyDinhHoaNhap, DateTime NgayQuyDinhHoaNhap, DateTime NgayVeDiaPhuong, string SoQuyDinhTaiNghien, DateTime NgayQuyDinhTaiNghien, Guid IdQuanLy, string TongHop, string MaRutGon, string MaTp, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TienSuDoiTuongEntity _TienSuDoiTuongEntity = new TienSuDoiTuongEntity(Id);
				if (adapter.FetchEntity(_TienSuDoiTuongEntity))
				{
				
					_TienSuDoiTuongEntity.IdDoiTuong = IdDoiTuong;
					_TienSuDoiTuongEntity.IdXuLyHanhChinh = IdXuLyHanhChinh;
					_TienSuDoiTuongEntity.IdHanhVi = IdHanhVi;
					_TienSuDoiTuongEntity.SoQuyDinh = SoQuyDinh;
					_TienSuDoiTuongEntity.NgayQuyDinh = NgayQuyDinh;
					_TienSuDoiTuongEntity.NgayBatDau = NgayBatDau;
					_TienSuDoiTuongEntity.NgayKetThuc = NgayKetThuc;
					_TienSuDoiTuongEntity.MucPhatTien = MucPhatTien;
					_TienSuDoiTuongEntity.SoXl135 = SoXl135;
					_TienSuDoiTuongEntity.NgayXl135 = NgayXl135;
					_TienSuDoiTuongEntity.IdCscb = IdCscb;
					_TienSuDoiTuongEntity.NgayTron = NgayTron;
					_TienSuDoiTuongEntity.NgayBatLai = NgayBatLai;
					_TienSuDoiTuongEntity.SoQuyDinhTruyTim = SoQuyDinhTruyTim;
					_TienSuDoiTuongEntity.NgayQuyDinhTruyTim = NgayQuyDinhTruyTim;
					_TienSuDoiTuongEntity.SoQuyDinhHoaNhap = SoQuyDinhHoaNhap;
					_TienSuDoiTuongEntity.NgayQuyDinhHoaNhap = NgayQuyDinhHoaNhap;
					_TienSuDoiTuongEntity.NgayVeDiaPhuong = NgayVeDiaPhuong;
					_TienSuDoiTuongEntity.SoQuyDinhTaiNghien = SoQuyDinhTaiNghien;
					_TienSuDoiTuongEntity.NgayQuyDinhTaiNghien = NgayQuyDinhTaiNghien;
					_TienSuDoiTuongEntity.IdQuanLy = IdQuanLy;
					_TienSuDoiTuongEntity.TongHop = TongHop;
					_TienSuDoiTuongEntity.MaRutGon = MaRutGon;
					_TienSuDoiTuongEntity.MaTp = MaTp;
					_TienSuDoiTuongEntity.LoaiDanhMuc = LoaiDanhMuc;
					_TienSuDoiTuongEntity.IdNguoiTao = IdNguoiTao;
					_TienSuDoiTuongEntity.NgayTao = NgayTao;
					_TienSuDoiTuongEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_TienSuDoiTuongEntity.NgayCapNhat = NgayCapNhat;
					_TienSuDoiTuongEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_TienSuDoiTuongEntity, true);
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
				TienSuDoiTuongEntity _TienSuDoiTuongEntity = new TienSuDoiTuongEntity(Id);
				if (adapter.FetchEntity(_TienSuDoiTuongEntity))
				{
					adapter.DeleteEntity(_TienSuDoiTuongEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdDoiTuong(Guid IdDoiTuong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdXuLyHanhChinh(Guid IdXuLyHanhChinh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdXuLyHanhChinh == IdXuLyHanhChinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdHanhVi(Guid IdHanhVi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdHanhVi == IdHanhVi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySoQuyDinh(string SoQuyDinh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.SoQuyDinh == SoQuyDinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayQuyDinh(DateTime NgayQuyDinh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayQuyDinh == NgayQuyDinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayBatDau(DateTime NgayBatDau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayBatDau == NgayBatDau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayKetThuc(DateTime NgayKetThuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayKetThuc == NgayKetThuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMucPhatTien(decimal MucPhatTien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.MucPhatTien == MucPhatTien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySoXl135(string SoXl135)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.SoXl135 == SoXl135);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayXl135(DateTime NgayXl135)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayXl135 == NgayXl135);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdCscb(Guid IdCscb)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdCscb == IdCscb);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTron(DateTime NgayTron)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayTron == NgayTron);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayBatLai(DateTime NgayBatLai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayBatLai == NgayBatLai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySoQuyDinhTruyTim(string SoQuyDinhTruyTim)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.SoQuyDinhTruyTim == SoQuyDinhTruyTim);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayQuyDinhTruyTim(DateTime NgayQuyDinhTruyTim)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayQuyDinhTruyTim == NgayQuyDinhTruyTim);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySoQuyDinhHoaNhap(string SoQuyDinhHoaNhap)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.SoQuyDinhHoaNhap == SoQuyDinhHoaNhap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayQuyDinhHoaNhap(DateTime NgayQuyDinhHoaNhap)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayQuyDinhHoaNhap == NgayQuyDinhHoaNhap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayVeDiaPhuong(DateTime NgayVeDiaPhuong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayVeDiaPhuong == NgayVeDiaPhuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySoQuyDinhTaiNghien(string SoQuyDinhTaiNghien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.SoQuyDinhTaiNghien == SoQuyDinhTaiNghien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayQuyDinhTaiNghien(DateTime NgayQuyDinhTaiNghien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayQuyDinhTaiNghien == NgayQuyDinhTaiNghien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdQuanLy(Guid IdQuanLy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdQuanLy == IdQuanLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTongHop(string TongHop)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.TongHop == TongHop);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienSuDoiTuongEntity", filter);
			}
			return toReturn;
		}
		

		
		public TienSuDoiTuongEntity SelectOne(Guid Id)
		{
			TienSuDoiTuongEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TienSuDoiTuongEntity _TienSuDoiTuongEntity = new TienSuDoiTuongEntity(Id);
				if (adapter.FetchEntity(_TienSuDoiTuongEntity))
				{
					toReturn = _TienSuDoiTuongEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectAllLST()
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, null, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByIdDoiTuongLST(Guid IdDoiTuong)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByIdDoiTuongLST_Paged(Guid IdDoiTuong, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdDoiTuongRDT(Guid IdDoiTuong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdDoiTuongRDT_Paged(Guid IdDoiTuong, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByIdXuLyHanhChinhLST(Guid IdXuLyHanhChinh)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdXuLyHanhChinh == IdXuLyHanhChinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByIdXuLyHanhChinhLST_Paged(Guid IdXuLyHanhChinh, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdXuLyHanhChinh == IdXuLyHanhChinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdXuLyHanhChinhRDT(Guid IdXuLyHanhChinh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdXuLyHanhChinh == IdXuLyHanhChinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdXuLyHanhChinhRDT_Paged(Guid IdXuLyHanhChinh, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdXuLyHanhChinh == IdXuLyHanhChinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByIdHanhViLST(Guid IdHanhVi)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdHanhVi == IdHanhVi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByIdHanhViLST_Paged(Guid IdHanhVi, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdHanhVi == IdHanhVi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdHanhViRDT(Guid IdHanhVi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdHanhVi == IdHanhVi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdHanhViRDT_Paged(Guid IdHanhVi, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdHanhVi == IdHanhVi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectBySoQuyDinhLST(string SoQuyDinh)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.SoQuyDinh == SoQuyDinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectBySoQuyDinhLST_Paged(string SoQuyDinh, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.SoQuyDinh == SoQuyDinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySoQuyDinhRDT(string SoQuyDinh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.SoQuyDinh == SoQuyDinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySoQuyDinhRDT_Paged(string SoQuyDinh, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.SoQuyDinh == SoQuyDinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByNgayQuyDinhLST(DateTime NgayQuyDinh)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayQuyDinh == NgayQuyDinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByNgayQuyDinhLST_Paged(DateTime NgayQuyDinh, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayQuyDinh == NgayQuyDinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayQuyDinhRDT(DateTime NgayQuyDinh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayQuyDinh == NgayQuyDinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayQuyDinhRDT_Paged(DateTime NgayQuyDinh, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayQuyDinh == NgayQuyDinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByNgayBatDauLST(DateTime NgayBatDau)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayBatDau == NgayBatDau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByNgayBatDauLST_Paged(DateTime NgayBatDau, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayBatDau == NgayBatDau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayBatDauRDT(DateTime NgayBatDau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayBatDau == NgayBatDau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayBatDauRDT_Paged(DateTime NgayBatDau, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayBatDau == NgayBatDau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByNgayKetThucLST(DateTime NgayKetThuc)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayKetThuc == NgayKetThuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByNgayKetThucLST_Paged(DateTime NgayKetThuc, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayKetThuc == NgayKetThuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayKetThucRDT(DateTime NgayKetThuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayKetThuc == NgayKetThuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayKetThucRDT_Paged(DateTime NgayKetThuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayKetThuc == NgayKetThuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByMucPhatTienLST(decimal MucPhatTien)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.MucPhatTien == MucPhatTien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByMucPhatTienLST_Paged(decimal MucPhatTien, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.MucPhatTien == MucPhatTien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMucPhatTienRDT(decimal MucPhatTien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.MucPhatTien == MucPhatTien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMucPhatTienRDT_Paged(decimal MucPhatTien, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.MucPhatTien == MucPhatTien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectBySoXl135LST(string SoXl135)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.SoXl135 == SoXl135);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectBySoXl135LST_Paged(string SoXl135, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.SoXl135 == SoXl135);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySoXl135RDT(string SoXl135)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.SoXl135 == SoXl135);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySoXl135RDT_Paged(string SoXl135, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.SoXl135 == SoXl135);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByNgayXl135LST(DateTime NgayXl135)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayXl135 == NgayXl135);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByNgayXl135LST_Paged(DateTime NgayXl135, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayXl135 == NgayXl135);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayXl135RDT(DateTime NgayXl135)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayXl135 == NgayXl135);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayXl135RDT_Paged(DateTime NgayXl135, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayXl135 == NgayXl135);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByIdCscbLST(Guid IdCscb)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdCscb == IdCscb);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByIdCscbLST_Paged(Guid IdCscb, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdCscb == IdCscb);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdCscbRDT(Guid IdCscb)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdCscb == IdCscb);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdCscbRDT_Paged(Guid IdCscb, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdCscb == IdCscb);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByNgayTronLST(DateTime NgayTron)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayTron == NgayTron);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByNgayTronLST_Paged(DateTime NgayTron, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayTron == NgayTron);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTronRDT(DateTime NgayTron)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayTron == NgayTron);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTronRDT_Paged(DateTime NgayTron, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayTron == NgayTron);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByNgayBatLaiLST(DateTime NgayBatLai)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayBatLai == NgayBatLai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByNgayBatLaiLST_Paged(DateTime NgayBatLai, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayBatLai == NgayBatLai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayBatLaiRDT(DateTime NgayBatLai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayBatLai == NgayBatLai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayBatLaiRDT_Paged(DateTime NgayBatLai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayBatLai == NgayBatLai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectBySoQuyDinhTruyTimLST(string SoQuyDinhTruyTim)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.SoQuyDinhTruyTim == SoQuyDinhTruyTim);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectBySoQuyDinhTruyTimLST_Paged(string SoQuyDinhTruyTim, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.SoQuyDinhTruyTim == SoQuyDinhTruyTim);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySoQuyDinhTruyTimRDT(string SoQuyDinhTruyTim)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.SoQuyDinhTruyTim == SoQuyDinhTruyTim);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySoQuyDinhTruyTimRDT_Paged(string SoQuyDinhTruyTim, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.SoQuyDinhTruyTim == SoQuyDinhTruyTim);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByNgayQuyDinhTruyTimLST(DateTime NgayQuyDinhTruyTim)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayQuyDinhTruyTim == NgayQuyDinhTruyTim);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByNgayQuyDinhTruyTimLST_Paged(DateTime NgayQuyDinhTruyTim, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayQuyDinhTruyTim == NgayQuyDinhTruyTim);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayQuyDinhTruyTimRDT(DateTime NgayQuyDinhTruyTim)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayQuyDinhTruyTim == NgayQuyDinhTruyTim);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayQuyDinhTruyTimRDT_Paged(DateTime NgayQuyDinhTruyTim, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayQuyDinhTruyTim == NgayQuyDinhTruyTim);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectBySoQuyDinhHoaNhapLST(string SoQuyDinhHoaNhap)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.SoQuyDinhHoaNhap == SoQuyDinhHoaNhap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectBySoQuyDinhHoaNhapLST_Paged(string SoQuyDinhHoaNhap, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.SoQuyDinhHoaNhap == SoQuyDinhHoaNhap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySoQuyDinhHoaNhapRDT(string SoQuyDinhHoaNhap)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.SoQuyDinhHoaNhap == SoQuyDinhHoaNhap);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySoQuyDinhHoaNhapRDT_Paged(string SoQuyDinhHoaNhap, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.SoQuyDinhHoaNhap == SoQuyDinhHoaNhap);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByNgayQuyDinhHoaNhapLST(DateTime NgayQuyDinhHoaNhap)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayQuyDinhHoaNhap == NgayQuyDinhHoaNhap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByNgayQuyDinhHoaNhapLST_Paged(DateTime NgayQuyDinhHoaNhap, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayQuyDinhHoaNhap == NgayQuyDinhHoaNhap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayQuyDinhHoaNhapRDT(DateTime NgayQuyDinhHoaNhap)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayQuyDinhHoaNhap == NgayQuyDinhHoaNhap);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayQuyDinhHoaNhapRDT_Paged(DateTime NgayQuyDinhHoaNhap, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayQuyDinhHoaNhap == NgayQuyDinhHoaNhap);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByNgayVeDiaPhuongLST(DateTime NgayVeDiaPhuong)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayVeDiaPhuong == NgayVeDiaPhuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByNgayVeDiaPhuongLST_Paged(DateTime NgayVeDiaPhuong, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayVeDiaPhuong == NgayVeDiaPhuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayVeDiaPhuongRDT(DateTime NgayVeDiaPhuong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayVeDiaPhuong == NgayVeDiaPhuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayVeDiaPhuongRDT_Paged(DateTime NgayVeDiaPhuong, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayVeDiaPhuong == NgayVeDiaPhuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectBySoQuyDinhTaiNghienLST(string SoQuyDinhTaiNghien)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.SoQuyDinhTaiNghien == SoQuyDinhTaiNghien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectBySoQuyDinhTaiNghienLST_Paged(string SoQuyDinhTaiNghien, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.SoQuyDinhTaiNghien == SoQuyDinhTaiNghien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySoQuyDinhTaiNghienRDT(string SoQuyDinhTaiNghien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.SoQuyDinhTaiNghien == SoQuyDinhTaiNghien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySoQuyDinhTaiNghienRDT_Paged(string SoQuyDinhTaiNghien, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.SoQuyDinhTaiNghien == SoQuyDinhTaiNghien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByNgayQuyDinhTaiNghienLST(DateTime NgayQuyDinhTaiNghien)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayQuyDinhTaiNghien == NgayQuyDinhTaiNghien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByNgayQuyDinhTaiNghienLST_Paged(DateTime NgayQuyDinhTaiNghien, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayQuyDinhTaiNghien == NgayQuyDinhTaiNghien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayQuyDinhTaiNghienRDT(DateTime NgayQuyDinhTaiNghien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayQuyDinhTaiNghien == NgayQuyDinhTaiNghien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayQuyDinhTaiNghienRDT_Paged(DateTime NgayQuyDinhTaiNghien, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayQuyDinhTaiNghien == NgayQuyDinhTaiNghien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByIdQuanLyLST(Guid IdQuanLy)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdQuanLy == IdQuanLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByIdQuanLyLST_Paged(Guid IdQuanLy, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdQuanLy == IdQuanLy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdQuanLyRDT(Guid IdQuanLy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdQuanLy == IdQuanLy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdQuanLyRDT_Paged(Guid IdQuanLy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdQuanLy == IdQuanLy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByTongHopLST(string TongHop)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.TongHop == TongHop);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByTongHopLST_Paged(string TongHop, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.TongHop == TongHop);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTongHopRDT(string TongHop)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.TongHop == TongHop);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTongHopRDT_Paged(string TongHop, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.TongHop == TongHop);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return EntityCollection<TienSuDoiTuongEntity>
		public EntityCollection<TienSuDoiTuongEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<TienSuDoiTuongEntity> _TienSuDoiTuongCollection = new EntityCollection<TienSuDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienSuDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienSuDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienSuDoiTuongCollection = new EntityCollection(new TienSuDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienSuDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienSuDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
