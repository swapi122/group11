




/*
'===============================================================================
'  LayerHelper.CAQ.BL.ToChucManagerBase
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
	public class ToChucManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ToChucManagerBase()
		{
			// Nothing for now.
		}
		
		public ToChucEntity Insert(ToChucEntity _ToChucEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_ToChucEntity, true);
			}
			return _ToChucEntity;
		}

		
		public ToChucEntity Insert(Guid Id, string TenToChuc, string MaRutGon, Guid IdNuoc, Guid IdTinh, Guid IdHuyen, Guid IdXa, string Duong, string SoNha, string DiaChiKhac, string TonChi, string DoiTuongDungDau, string SoDienThoai, int TongSoDoiTuong, string ThanhVien, string MangLuoi, string BieuTuong, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			ToChucEntity _ToChucEntity = new ToChucEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ToChucEntity.Id = Id;
				_ToChucEntity.TenToChuc = TenToChuc;
				_ToChucEntity.MaRutGon = MaRutGon;
				_ToChucEntity.IdNuoc = IdNuoc;
				_ToChucEntity.IdTinh = IdTinh;
				_ToChucEntity.IdHuyen = IdHuyen;
				_ToChucEntity.IdXa = IdXa;
				_ToChucEntity.Duong = Duong;
				_ToChucEntity.SoNha = SoNha;
				_ToChucEntity.DiaChiKhac = DiaChiKhac;
				_ToChucEntity.TonChi = TonChi;
				_ToChucEntity.DoiTuongDungDau = DoiTuongDungDau;
				_ToChucEntity.SoDienThoai = SoDienThoai;
				_ToChucEntity.TongSoDoiTuong = TongSoDoiTuong;
				_ToChucEntity.ThanhVien = ThanhVien;
				_ToChucEntity.MangLuoi = MangLuoi;
				_ToChucEntity.BieuTuong = BieuTuong;
				_ToChucEntity.IdNguoiTao = IdNguoiTao;
				_ToChucEntity.NgayTao = NgayTao;
				_ToChucEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_ToChucEntity.NgayCapNhat = NgayCapNhat;
				_ToChucEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_ToChucEntity, true);
			}
			return _ToChucEntity;
		}

		public ToChucEntity Insert(string TenToChuc, string MaRutGon, Guid IdNuoc, Guid IdTinh, Guid IdHuyen, Guid IdXa, string Duong, string SoNha, string DiaChiKhac, string TonChi, string DoiTuongDungDau, string SoDienThoai, int TongSoDoiTuong, string ThanhVien, string MangLuoi, string BieuTuong, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			ToChucEntity _ToChucEntity = new ToChucEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ToChucEntity.TenToChuc = TenToChuc;
				_ToChucEntity.MaRutGon = MaRutGon;
				_ToChucEntity.IdNuoc = IdNuoc;
				_ToChucEntity.IdTinh = IdTinh;
				_ToChucEntity.IdHuyen = IdHuyen;
				_ToChucEntity.IdXa = IdXa;
				_ToChucEntity.Duong = Duong;
				_ToChucEntity.SoNha = SoNha;
				_ToChucEntity.DiaChiKhac = DiaChiKhac;
				_ToChucEntity.TonChi = TonChi;
				_ToChucEntity.DoiTuongDungDau = DoiTuongDungDau;
				_ToChucEntity.SoDienThoai = SoDienThoai;
				_ToChucEntity.TongSoDoiTuong = TongSoDoiTuong;
				_ToChucEntity.ThanhVien = ThanhVien;
				_ToChucEntity.MangLuoi = MangLuoi;
				_ToChucEntity.BieuTuong = BieuTuong;
				_ToChucEntity.IdNguoiTao = IdNguoiTao;
				_ToChucEntity.NgayTao = NgayTao;
				_ToChucEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_ToChucEntity.NgayCapNhat = NgayCapNhat;
				_ToChucEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_ToChucEntity, true);
			}
			return _ToChucEntity;
		}

		public bool Update(ToChucEntity _ToChucEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(ToChucFields.Id == _ToChucEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_ToChucEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(ToChucEntity _ToChucEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_ToChucEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenToChuc, string MaRutGon, Guid IdNuoc, Guid IdTinh, Guid IdHuyen, Guid IdXa, string Duong, string SoNha, string DiaChiKhac, string TonChi, string DoiTuongDungDau, string SoDienThoai, int TongSoDoiTuong, string ThanhVien, string MangLuoi, string BieuTuong, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ToChucEntity _ToChucEntity = new ToChucEntity(Id);
				if (adapter.FetchEntity(_ToChucEntity))
				{
				
					_ToChucEntity.TenToChuc = TenToChuc;
					_ToChucEntity.MaRutGon = MaRutGon;
					_ToChucEntity.IdNuoc = IdNuoc;
					_ToChucEntity.IdTinh = IdTinh;
					_ToChucEntity.IdHuyen = IdHuyen;
					_ToChucEntity.IdXa = IdXa;
					_ToChucEntity.Duong = Duong;
					_ToChucEntity.SoNha = SoNha;
					_ToChucEntity.DiaChiKhac = DiaChiKhac;
					_ToChucEntity.TonChi = TonChi;
					_ToChucEntity.DoiTuongDungDau = DoiTuongDungDau;
					_ToChucEntity.SoDienThoai = SoDienThoai;
					_ToChucEntity.TongSoDoiTuong = TongSoDoiTuong;
					_ToChucEntity.ThanhVien = ThanhVien;
					_ToChucEntity.MangLuoi = MangLuoi;
					_ToChucEntity.BieuTuong = BieuTuong;
					_ToChucEntity.IdNguoiTao = IdNguoiTao;
					_ToChucEntity.NgayTao = NgayTao;
					_ToChucEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_ToChucEntity.NgayCapNhat = NgayCapNhat;
					_ToChucEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_ToChucEntity, true);
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
				ToChucEntity _ToChucEntity = new ToChucEntity(Id);
				if (adapter.FetchEntity(_ToChucEntity))
				{
					adapter.DeleteEntity(_ToChucEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("ToChucEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenToChuc(string TenToChuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.TenToChuc == TenToChuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNuoc(Guid IdNuoc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.IdNuoc == IdNuoc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdTinh(Guid IdTinh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.IdTinh == IdTinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdHuyen(Guid IdHuyen)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.IdHuyen == IdHuyen);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdXa(Guid IdXa)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.IdXa == IdXa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDuong(string Duong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.Duong == Duong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySoNha(string SoNha)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.SoNha == SoNha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDiaChiKhac(string DiaChiKhac)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.DiaChiKhac == DiaChiKhac);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTonChi(string TonChi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.TonChi == TonChi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDoiTuongDungDau(string DoiTuongDungDau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.DoiTuongDungDau == DoiTuongDungDau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySoDienThoai(string SoDienThoai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.SoDienThoai == SoDienThoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTongSoDoiTuong(int TongSoDoiTuong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.TongSoDoiTuong == TongSoDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByThanhVien(string ThanhVien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.ThanhVien == ThanhVien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMangLuoi(string MangLuoi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.MangLuoi == MangLuoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByBieuTuong(string BieuTuong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.BieuTuong == BieuTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ToChucEntity", filter);
			}
			return toReturn;
		}
		

		
		public ToChucEntity SelectOne(Guid Id)
		{
			ToChucEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ToChucEntity _ToChucEntity = new ToChucEntity(Id);
				if (adapter.FetchEntity(_ToChucEntity))
				{
					toReturn = _ToChucEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectAllLST()
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, null, 0, null);
			}
			return _ToChucCollection;
		}
		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _ToChucCollection;
		}


		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null);
			}
			return _ToChucCollection;
		}
		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByTenToChucLST(string TenToChuc)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.TenToChuc == TenToChuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null);
			}
			return _ToChucCollection;
		}
		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByTenToChucLST_Paged(string TenToChuc, int PageNumber, int PageSize)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.TenToChuc == TenToChuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenToChucRDT(string TenToChuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.TenToChuc == TenToChuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenToChucRDT_Paged(string TenToChuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.TenToChuc == TenToChuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null);
			}
			return _ToChucCollection;
		}
		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByIdNuocLST(Guid IdNuoc)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.IdNuoc == IdNuoc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null);
			}
			return _ToChucCollection;
		}
		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByIdNuocLST_Paged(Guid IdNuoc, int PageNumber, int PageSize)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.IdNuoc == IdNuoc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNuocRDT(Guid IdNuoc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.IdNuoc == IdNuoc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNuocRDT_Paged(Guid IdNuoc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.IdNuoc == IdNuoc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByIdTinhLST(Guid IdTinh)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.IdTinh == IdTinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null);
			}
			return _ToChucCollection;
		}
		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByIdTinhLST_Paged(Guid IdTinh, int PageNumber, int PageSize)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.IdTinh == IdTinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdTinhRDT(Guid IdTinh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.IdTinh == IdTinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdTinhRDT_Paged(Guid IdTinh, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.IdTinh == IdTinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByIdHuyenLST(Guid IdHuyen)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.IdHuyen == IdHuyen);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null);
			}
			return _ToChucCollection;
		}
		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByIdHuyenLST_Paged(Guid IdHuyen, int PageNumber, int PageSize)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.IdHuyen == IdHuyen);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdHuyenRDT(Guid IdHuyen)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.IdHuyen == IdHuyen);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdHuyenRDT_Paged(Guid IdHuyen, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.IdHuyen == IdHuyen);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByIdXaLST(Guid IdXa)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.IdXa == IdXa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null);
			}
			return _ToChucCollection;
		}
		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByIdXaLST_Paged(Guid IdXa, int PageNumber, int PageSize)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.IdXa == IdXa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdXaRDT(Guid IdXa)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.IdXa == IdXa);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdXaRDT_Paged(Guid IdXa, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.IdXa == IdXa);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByDuongLST(string Duong)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.Duong == Duong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null);
			}
			return _ToChucCollection;
		}
		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByDuongLST_Paged(string Duong, int PageNumber, int PageSize)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.Duong == Duong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDuongRDT(string Duong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.Duong == Duong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDuongRDT_Paged(string Duong, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.Duong == Duong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectBySoNhaLST(string SoNha)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.SoNha == SoNha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null);
			}
			return _ToChucCollection;
		}
		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectBySoNhaLST_Paged(string SoNha, int PageNumber, int PageSize)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.SoNha == SoNha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySoNhaRDT(string SoNha)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.SoNha == SoNha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySoNhaRDT_Paged(string SoNha, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.SoNha == SoNha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByDiaChiKhacLST(string DiaChiKhac)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.DiaChiKhac == DiaChiKhac);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null);
			}
			return _ToChucCollection;
		}
		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByDiaChiKhacLST_Paged(string DiaChiKhac, int PageNumber, int PageSize)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.DiaChiKhac == DiaChiKhac);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDiaChiKhacRDT(string DiaChiKhac)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.DiaChiKhac == DiaChiKhac);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDiaChiKhacRDT_Paged(string DiaChiKhac, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.DiaChiKhac == DiaChiKhac);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByTonChiLST(string TonChi)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.TonChi == TonChi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null);
			}
			return _ToChucCollection;
		}
		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByTonChiLST_Paged(string TonChi, int PageNumber, int PageSize)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.TonChi == TonChi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTonChiRDT(string TonChi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.TonChi == TonChi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTonChiRDT_Paged(string TonChi, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.TonChi == TonChi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByDoiTuongDungDauLST(string DoiTuongDungDau)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.DoiTuongDungDau == DoiTuongDungDau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null);
			}
			return _ToChucCollection;
		}
		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByDoiTuongDungDauLST_Paged(string DoiTuongDungDau, int PageNumber, int PageSize)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.DoiTuongDungDau == DoiTuongDungDau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDoiTuongDungDauRDT(string DoiTuongDungDau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.DoiTuongDungDau == DoiTuongDungDau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDoiTuongDungDauRDT_Paged(string DoiTuongDungDau, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.DoiTuongDungDau == DoiTuongDungDau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectBySoDienThoaiLST(string SoDienThoai)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.SoDienThoai == SoDienThoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null);
			}
			return _ToChucCollection;
		}
		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectBySoDienThoaiLST_Paged(string SoDienThoai, int PageNumber, int PageSize)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.SoDienThoai == SoDienThoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySoDienThoaiRDT(string SoDienThoai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.SoDienThoai == SoDienThoai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySoDienThoaiRDT_Paged(string SoDienThoai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.SoDienThoai == SoDienThoai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByTongSoDoiTuongLST(int TongSoDoiTuong)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.TongSoDoiTuong == TongSoDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null);
			}
			return _ToChucCollection;
		}
		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByTongSoDoiTuongLST_Paged(int TongSoDoiTuong, int PageNumber, int PageSize)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.TongSoDoiTuong == TongSoDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTongSoDoiTuongRDT(int TongSoDoiTuong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.TongSoDoiTuong == TongSoDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTongSoDoiTuongRDT_Paged(int TongSoDoiTuong, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.TongSoDoiTuong == TongSoDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByThanhVienLST(string ThanhVien)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.ThanhVien == ThanhVien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null);
			}
			return _ToChucCollection;
		}
		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByThanhVienLST_Paged(string ThanhVien, int PageNumber, int PageSize)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.ThanhVien == ThanhVien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByThanhVienRDT(string ThanhVien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.ThanhVien == ThanhVien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByThanhVienRDT_Paged(string ThanhVien, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.ThanhVien == ThanhVien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByMangLuoiLST(string MangLuoi)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.MangLuoi == MangLuoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null);
			}
			return _ToChucCollection;
		}
		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByMangLuoiLST_Paged(string MangLuoi, int PageNumber, int PageSize)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.MangLuoi == MangLuoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMangLuoiRDT(string MangLuoi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.MangLuoi == MangLuoi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMangLuoiRDT_Paged(string MangLuoi, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.MangLuoi == MangLuoi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByBieuTuongLST(string BieuTuong)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.BieuTuong == BieuTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null);
			}
			return _ToChucCollection;
		}
		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByBieuTuongLST_Paged(string BieuTuong, int PageNumber, int PageSize)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.BieuTuong == BieuTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByBieuTuongRDT(string BieuTuong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.BieuTuong == BieuTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByBieuTuongRDT_Paged(string BieuTuong, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.BieuTuong == BieuTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null);
			}
			return _ToChucCollection;
		}
		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null);
			}
			return _ToChucCollection;
		}
		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null);
			}
			return _ToChucCollection;
		}
		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null);
			}
			return _ToChucCollection;
		}
		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null);
			}
			return _ToChucCollection;
		}
		
		// Return EntityCollection<ToChucEntity>
		public EntityCollection<ToChucEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<ToChucEntity> _ToChucCollection = new EntityCollection<ToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _ToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ToChucCollection = new EntityCollection(new ToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ToChucFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
